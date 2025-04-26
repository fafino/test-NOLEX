using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace test_NOLEX
{
    public partial class FormMain : Form
    {
        SQLiteConnection connection;
        //SqlConnection connection;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_fileDB_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "sqlite files (*.sqlite)|*.sqlite|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                if (textBox_DB.Text != "")
                {
                    openFileDialog1.InitialDirectory = Path.GetDirectoryName(textBox_DB.Text);
                }
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox_DB.Text = openFileDialog1.FileName;
                }

                //collegamento al DB
                string connectionString = "Data Source=" + textBox_DB.Text + ";Version=3;";
                //string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=nolexDB;Trusted_Connection=True;";
                connection = new SQLiteConnection(connectionString);

                connection.Open();
                //MessageBox.Show("Connessione al database SQLite riuscita!");


                //button_filtra_Click(sender, e);

                caricaeSelezionaAmbulatorio(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la selezione del file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                
                string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=nolexDB;Trusted_Connection=True;";
                connection = new SqlConnection(connectionString);

                connection.Open();
                //MessageBox.Show("Connessione al database SQLite riuscita!");

                string query = "SELECT nome FROM ambulatori";
                using (SqlCommand command = new SqlCommand(query, connection))
                {                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        caricaAmbulatori(reader);
                    }
                }

                // Seleziona il primo elemento se esiste
                if (listBox_ambulatori.Items.Count > 0)
                {
                    listBox_ambulatori.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la selezione del file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private string aggiungiFiltriEsami(string query)
        {

            if (textBox_filtraCI.Text != "")
            {
                query += "AND LOWER(esami.CodiceInterno) LIKE '%' || LOWER('" + textBox_filtraCI.Text + "') || '%' ";
                //query += "AND CodiceInterno LIKE '%' + @filtroCodiceInterno + '%' ";
            }
            if (textBox_filtraCM.Text != "")
            {
                query += "AND LOWER(esami.CodiceMinisteriale) LIKE '%' || LOWER('" + textBox_filtraCM.Text + "') || '%' ";
                //query += "AND CodiceMinisteriale LIKE '%' + @filtroCodiceMinisteriale + '%' ";
            }
            if (textBox_filtraDescrizione.Text != "")
            {
                query += "AND LOWER(esami.DescrizioneEsame) LIKE '%' || LOWER('" + textBox_filtraDescrizione.Text + "') || '%' ";
                //query += "AND DescrizioneEsame LIKE '%' + @filtroDescrizioneEsame + '%' ";
            }
            return query;
        }

        private void listBox_ambulatori_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox_ambulatori.Text != "")
            {
                //filtro esami in base all'ambulatorio selezionato
                string query = "SELECT CodiceMinisteriale, CodiceInterno, DescrizioneEsame  " +
                    "FROM ambulatori, esami, ambulatori_esami " +
                    "WHERE ambulatori.id = ambulatori_esami.ambulatori_id " +
                    "AND esami.id = ambulatori_esami.esami_id " +
                    "AND ambulatori.nome = @nomeAmbulatorio ";
                query = aggiungiFiltriEsami(query);

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeAmbulatorio", listBox_ambulatori.Text);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        caricaEsami(reader);
                    }
                }

                //filtro parti corpo in base all'ambulatorio selezionato
                query = "SELECT distinct(descrizione) " +
                    "FROM esami, ambulatori_esami, ambulatori, particorpo " +
                    "WHERE esami.id = ambulatori_esami.esami_id " +
                    "AND ambulatori.id = ambulatori_esami.ambulatori_id " +
                    "AND particorpo.id = esami.particorpo_id " +
                    "AND ambulatori.nome = @nomeAmbulatorio ";
                query = aggiungiFiltriEsami(query);
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeAmbulatorio", listBox_ambulatori.Text);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        caricaPartiDelCorpo(reader);
                    }
                }
            }
        }

        private void listBox_partiCorpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBox_ambulatori.Text != "") && (listBox_partiCorpo.Text != ""))
            {
                string query = "SELECT DescrizioneEsame, CodiceMinisteriale, CodiceInterno " +
                    "FROM esami, ambulatori_esami, ambulatori, particorpo " +
                    "WHERE esami.id = ambulatori_esami.esami_id " +
                    "AND ambulatori.id = ambulatori_esami.ambulatori_id " +
                    "AND ambulatori.nome = @nomeAmbulatorio " +
                    "AND particorpo.descrizione = @descrizionePartiCorpo " +
                    "AND esami.particorpo_id = particorpo.id ";
                query = aggiungiFiltriEsami(query);

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeAmbulatorio", listBox_ambulatori.Text);
                    command.Parameters.AddWithValue("@descrizionePartiCorpo", listBox_partiCorpo.Text);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        caricaEsami(reader);
                    }
                }
            }
        }

        private void caricaEsami(SQLiteDataReader reader)
        {
            listView_esami.View = View.Details;
            listView_esami.Columns.Clear();
            listView_esami.Columns.Add("Codice Interno", 100);
            listView_esami.Columns.Add("Codice Ministeriale", 100);
            listView_esami.Columns.Add("Descrizione Esame", 200);

            listView_esami.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["CodiceInterno"].ToString());
                item.SubItems.Add(reader["CodiceMinisteriale"].ToString());
                item.SubItems.Add(reader["DescrizioneEsame"].ToString());
                listView_esami.Items.Add(item);
            }
        }

        private void caricaPartiDelCorpo(SQLiteDataReader reader)
        {
            listBox_partiCorpo.Items.Clear();
            HashSet<string> descrizioniUnici = new HashSet<string>(); // Per tenere traccia dei valori unici
            while (reader.Read())
            {
                string descrizione = reader["descrizione"].ToString();
                if (descrizioniUnici.Add(descrizione)) // Aggiunge solo se il valore non è già presente
                {
                    listBox_partiCorpo.Items.Add(descrizione);
                }
            }

        }

        private void caricaAmbulatori(SQLiteDataReader reader)
        {
            listBox_ambulatori.Items.Clear();
            HashSet<string> nomiUnici = new HashSet<string>(); // Per tenere traccia dei valori unici

            while (reader.Read())
            {
                string nome = reader["nome"].ToString();
                if (nomiUnici.Add(nome)) // Aggiunge solo se il valore non è già presente
                {
                    listBox_ambulatori.Items.Add(nome);
                }
            }
        }


        private void textBox_filtraCM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_filtra_Click(sender, e);
            }
        }

        private void textBox_filtraCI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_filtra_Click(sender, e);
            }
        }

        private void textBox_filtraDescrizione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_filtra_Click(sender, e);
            }
        }

        private void button_filtroReset_Click(object sender, EventArgs e)
        {
            textBox_filtraCI.Text = "";
            textBox_filtraCM.Text = "";
            textBox_filtraDescrizione.Text = "";

            string query = "SELECT * " +
                "FROM esami ";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    caricaEsami(reader);
                }
            }
        }

        private void listView_esami_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //deseleziono ambulatorio e parti del corpo altrimenti fanno parte del filtro
            listBox_ambulatori.ClearSelected();
            listBox_partiCorpo.ClearSelected();
            button_filtra_Click(sender, e);
        }

        private string CreaQuery()
        {
            string query = "SELECT CodiceInterno, CodiceMinisteriale, DescrizioneEsame, ambulatori.nome, particorpo.descrizione " +
                "FROM esami, ambulatori_esami, ambulatori, particorpo " +
                "WHERE esami.id = ambulatori_esami.esami_id " +
                "AND ambulatori.id = ambulatori_esami.ambulatori_id " +
                "AND esami.particorpo_id = particorpo.id ";
            if (listBox_ambulatori.SelectedItem != null)
            {
                string nomeAmbulatorio = listBox_ambulatori.SelectedItem.ToString();
                query += "AND ambulatori.nome = '" + nomeAmbulatorio + "' ";
            }
            if (listBox_partiCorpo.SelectedItem != null)
            {
                string descrizionePartiCorpo = listBox_partiCorpo.SelectedItem.ToString();
                query += "AND particorpo.descrizione = '" + descrizionePartiCorpo + "' ";
            }
            if (listView_esami.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_esami.SelectedItems[0];
                string codiceInterno = selectedItem.SubItems[0].Text;
                query += "AND esami.CodiceInterno = '" + codiceInterno + "' ";
            }

            query = aggiungiFiltriEsami(query);

            return query;
        }

        private void button_filtra_Click(object sender, EventArgs e)
        {
            string query = CreaQuery();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                //command.Parameters.AddWithValue("@filtroCodiceInterno", textBox_filtraCI.Text);
                //command.Parameters.AddWithValue("@filtroCodiceMinisteriale", textBox_filtraCM.Text);
                //command.Parameters.AddWithValue("@filtroDescrizioneEsame", textBox_filtraDescrizione.Text);
                // Primo ciclo: carica esami
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    listView_esami.View = View.Details;
                    listView_esami.Columns.Clear();
                    listView_esami.Columns.Add("Codice Interno", 100);
                    listView_esami.Columns.Add("Codice Ministeriale", 100);
                    listView_esami.Columns.Add("Descrizione Esame", 200);

                    listView_esami.Items.Clear();
                    HashSet<string> codiciUnici = new HashSet<string>(); // Per tenere traccia dei valori unici

                    listBox_ambulatori.Items.Clear();
                    HashSet<string> nomiUnici = new HashSet<string>(); // Per tenere traccia dei valori unici

                    listBox_partiCorpo.Items.Clear();
                    HashSet<string> descrizioniUnici = new HashSet<string>(); // Per tenere traccia dei valori unici

                    while (reader.Read())
                    {
                        string codice = reader["CodiceInterno"].ToString();
                        if (codiciUnici.Add(codice)) // Aggiunge solo se il valore non è già presente
                        {
                            ListViewItem item = new ListViewItem(codice);
                            item.SubItems.Add(reader["CodiceMinisteriale"].ToString());
                            item.SubItems.Add(reader["DescrizioneEsame"].ToString());
                            listView_esami.Items.Add(item);
                        }

                        string nome = reader["nome"].ToString();
                        if (nomiUnici.Add(nome)) // Aggiunge solo se il valore non è già presente
                        {
                            listBox_ambulatori.Items.Add(nome);
                        }

                        string descrizione = reader["descrizione"].ToString();
                        if (descrizioniUnici.Add(descrizione)) // Aggiunge solo se il valore non è già presente
                        {
                            listBox_partiCorpo.Items.Add(descrizione);
                        }
                    }
                }

            }
        }

        private void button_resetAmbulatori_Click(object sender, EventArgs e)
        {
            caricaeSelezionaAmbulatorio(sender, e);
        }

        private void caricaeSelezionaAmbulatorio(object sender, EventArgs e)
        {
            string query = "SELECT nome FROM ambulatori";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    caricaAmbulatori(reader);
                }
            }

            // Seleziona il primo elemento se esiste
            if (listBox_ambulatori.Items.Count > 0)
            {
                listBox_ambulatori.SelectedIndex = 0;
            }
        }

        private void button_prenotaEsame_Click(object sender, EventArgs e)
        {
            if (listBox_ambulatori.Text != "")
            {
                foreach (ListViewItem item in listView_esami.Items)
                {
                    if (item.Checked) // Controlla se il checkbox è selezionato
                    {
                        // Aggiungi una nuova riga alla DataGridView con i dati della ListView
                        dataGridView_prenotazioni.Rows.Add(
                            listBox_ambulatori.Text + " - " + item.SubItems[0].Text + "." + item.SubItems[1].Text + "." + item.SubItems[2].Text);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Devi selezionare un Ambulatorio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_prenotazioni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_prenotazioni.Columns["Cancella"].Index)
            {
                // Conferma la cancellazione
                var result = MessageBox.Show("Sei sicuro di voler cancellare questa prenotazione?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Rimuovi la riga selezionata
                    dataGridView_prenotazioni.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if(e.RowIndex >= 0 && e.ColumnIndex == dataGridView_prenotazioni.Columns["Modifica"].Index)
            {
                if (listBox_ambulatori.Text != "")
                {
                    // Controlla se almeno un elemento della ListView ha il checkbox selezionato
                    int esamiSelezionati = 0;
                    foreach (ListViewItem item in listView_esami.Items)
                    {
                        if (item.Checked)
                        {
                            esamiSelezionati++;
                        }
                    }
                    if (esamiSelezionati == 1) {
                        // Modifica la cancellazione
                        dataGridView_prenotazioni.Rows[e.RowIndex].Cells["label"].Value =
                            listBox_ambulatori.Text + " - " + listView_esami.Items[0].SubItems[0].Text + "." + listView_esami.Items[0].SubItems[1].Text + "." + listView_esami.Items[0].SubItems[2].Text;
                    } else
                    {
                        MessageBox.Show($"Devi selezionare un Esame", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show($"Devi selezionare un Ambulatorio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
