using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace test_NOLEX
{
    public partial class FormMain : Form
    {
        SQLiteConnection connection;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_DB_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=" + textBox_DB.Text + ";Version=3;";
                connection = new SQLiteConnection(connectionString);
                connection.Open();
                //MessageBox.Show("Connessione al database SQLite riuscita!");

                string query = "SELECT nome FROM ambulatori";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        listBox_ambulatori.Items.Clear();
                        while (reader.Read())
                        {
                            listBox_ambulatori.Items.Add(reader["nome"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la connessione: {ex.Message}");
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la selezione del file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox_ambulatori_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT CodiceMinisteriale, DescrizioneEsame  " +
                "FROM ambulatori, esami, ambulatori_esami " +
                "WHERE ambulatori.id = ambulatori_esami.ambulatori_id " +
                "AND esami.id = ambulatori_esami.esami_id " +
                "AND ambulatori.nome = @nomeAmbulatorio";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nomeAmbulatorio", listBox_ambulatori.Text);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    listBox_esami.Items.Clear();
                    while (reader.Read())
                    {
                        listBox_esami.Items.Add(reader["CodiceMinisteriale"].ToString() + ") " + reader["DescrizioneEsame"].ToString());
                    }
                }
            }

            query = "SELECT distinct(descrizione) " +
                "FROM esami, ambulatori_esami, ambulatori, particorpo " +
                "WHERE esami.id = ambulatori_esami.esami_id " +
                "AND ambulatori.id = ambulatori_esami.ambulatori_id " +
                "AND particorpo.id = esami.particorpo_id " +
                "AND ambulatori.nome = @nomeAmbulatorio";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nomeAmbulatorio", listBox_ambulatori.Text);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    listBox_partiCorpo.Items.Clear();
                    while (reader.Read())
                    {
                        listBox_partiCorpo.Items.Add(reader["descrizione"].ToString());
                    }
                }
            }
        }

        private void listBox_partiCorpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT DescrizioneEsame, CodiceMinisteriale " +
                "FROM esami, ambulatori_esami, ambulatori, particorpo " +
                "WHERE esami.id = ambulatori_esami.esami_id " +
                "AND ambulatori.id = ambulatori_esami.ambulatori_id " +
                "AND ambulatori.nome = @nomeAmbulatorio " +
                "AND particorpo.descrizione = @descrizionePartiCorpo " +
                "AND esami.particorpo_id = particorpo.id";
            

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nomeAmbulatorio", listBox_ambulatori.Text);
                command.Parameters.AddWithValue("@descrizionePartiCorpo", listBox_partiCorpo.Text);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    listBox_esami.Items.Clear();
                    while (reader.Read())
                    {
                        listBox_esami.Items.Add(reader["CodiceMinisteriale"].ToString() + ") " + reader["DescrizioneEsame"].ToString());
                    }
                }
            }
        }
    }
}
