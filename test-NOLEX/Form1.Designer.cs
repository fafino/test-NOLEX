namespace test_NOLEX
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_ambulatori = new ListBox();
            listBox_partiCorpo = new ListBox();
            buttonChiudi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_prenotaEsame = new Button();
            listView_esami = new ListView();
            CodiceMinisteriale = new ColumnHeader();
            CodiceInterno = new ColumnHeader();
            DescrizioneEsame = new ColumnHeader();
            groupBox1 = new GroupBox();
            button_filtroReset = new Button();
            button_filtraDescrizione = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox_filtraDescrizione = new TextBox();
            textBox_filtraCI = new TextBox();
            textBox_filtraCM = new TextBox();
            button_resetAmbulatori = new Button();
            dataGridView_prenotazioni = new DataGridView();
            label = new DataGridViewTextBoxColumn();
            Cancella = new DataGridViewImageColumn();
            Modifica = new DataGridViewImageColumn();
            button_confermaPrenotazione = new Button();
            label8 = new Label();
            button_salvaRicerca = new Button();
            button_getRicerca = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_prenotazioni).BeginInit();
            SuspendLayout();
            // 
            // listBox_ambulatori
            // 
            listBox_ambulatori.FormattingEnabled = true;
            listBox_ambulatori.Location = new Point(10, 45);
            listBox_ambulatori.Margin = new Padding(3, 2, 3, 2);
            listBox_ambulatori.Name = "listBox_ambulatori";
            listBox_ambulatori.Size = new Size(243, 334);
            listBox_ambulatori.TabIndex = 0;
            listBox_ambulatori.SelectedValueChanged += listBox_ambulatori_SelectedValueChanged;
            // 
            // listBox_partiCorpo
            // 
            listBox_partiCorpo.FormattingEnabled = true;
            listBox_partiCorpo.Location = new Point(259, 45);
            listBox_partiCorpo.Margin = new Padding(3, 2, 3, 2);
            listBox_partiCorpo.Name = "listBox_partiCorpo";
            listBox_partiCorpo.Size = new Size(305, 334);
            listBox_partiCorpo.TabIndex = 1;
            listBox_partiCorpo.SelectedIndexChanged += listBox_partiCorpo_SelectedIndexChanged;
            // 
            // buttonChiudi
            // 
            buttonChiudi.Location = new Point(992, 650);
            buttonChiudi.Margin = new Padding(3, 2, 3, 2);
            buttonChiudi.Name = "buttonChiudi";
            buttonChiudi.Size = new Size(82, 22);
            buttonChiudi.TabIndex = 3;
            buttonChiudi.Text = "Chiudi";
            buttonChiudi.UseVisualStyleBackColor = true;
            buttonChiudi.Click += buttonChiudi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Ambulatori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(259, 21);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Parti del Corpo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(570, 21);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Esami";
            // 
            // button_prenotaEsame
            // 
            button_prenotaEsame.Location = new Point(570, 392);
            button_prenotaEsame.Margin = new Padding(3, 2, 3, 2);
            button_prenotaEsame.Name = "button_prenotaEsame";
            button_prenotaEsame.Size = new Size(214, 22);
            button_prenotaEsame.TabIndex = 8;
            button_prenotaEsame.Text = "Prenota Esame";
            button_prenotaEsame.UseVisualStyleBackColor = true;
            button_prenotaEsame.Click += button_prenotaEsame_Click;
            // 
            // listView_esami
            // 
            listView_esami.CheckBoxes = true;
            listView_esami.Columns.AddRange(new ColumnHeader[] { CodiceMinisteriale, CodiceInterno, DescrizioneEsame });
            listView_esami.Location = new Point(570, 45);
            listView_esami.Margin = new Padding(3, 2, 3, 2);
            listView_esami.Name = "listView_esami";
            listView_esami.Size = new Size(504, 334);
            listView_esami.TabIndex = 12;
            listView_esami.UseCompatibleStateImageBehavior = false;
            listView_esami.ItemSelectionChanged += listView_esami_ItemSelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_filtroReset);
            groupBox1.Controls.Add(button_filtraDescrizione);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_filtraDescrizione);
            groupBox1.Controls.Add(textBox_filtraCI);
            groupBox1.Controls.Add(textBox_filtraCM);
            groupBox1.Location = new Point(259, 392);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(304, 238);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtra Esami";
            // 
            // button_filtroReset
            // 
            button_filtroReset.Location = new Point(139, 141);
            button_filtroReset.Margin = new Padding(3, 2, 3, 2);
            button_filtroReset.Name = "button_filtroReset";
            button_filtroReset.Size = new Size(151, 22);
            button_filtroReset.TabIndex = 29;
            button_filtroReset.Text = "Vedi Tutti gli Esami";
            button_filtroReset.UseVisualStyleBackColor = true;
            button_filtroReset.Click += button_filtroReset_Click;
            // 
            // button_filtraDescrizione
            // 
            button_filtraDescrizione.Location = new Point(202, 107);
            button_filtraDescrizione.Margin = new Padding(3, 2, 3, 2);
            button_filtraDescrizione.Name = "button_filtraDescrizione";
            button_filtraDescrizione.Size = new Size(88, 20);
            button_filtraDescrizione.TabIndex = 27;
            button_filtraDescrizione.Text = "Filtra";
            button_filtraDescrizione.UseVisualStyleBackColor = true;
            button_filtraDescrizione.Click += button_filtra_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 78);
            label7.Name = "label7";
            label7.Size = new Size(156, 15);
            label7.TabIndex = 23;
            label7.Text = "Filtra per Descrizione Esame:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 48);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 22;
            label6.Text = "Filtra per Codice Interno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 13);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 21;
            label5.Text = "Filtra per Codice Ministeriale:";
            // 
            // textBox_filtraDescrizione
            // 
            textBox_filtraDescrizione.Location = new Point(202, 75);
            textBox_filtraDescrizione.Margin = new Padding(3, 2, 3, 2);
            textBox_filtraDescrizione.Name = "textBox_filtraDescrizione";
            textBox_filtraDescrizione.Size = new Size(88, 23);
            textBox_filtraDescrizione.TabIndex = 19;
            textBox_filtraDescrizione.KeyDown += textBox_filtraDescrizione_KeyDown;
            // 
            // textBox_filtraCI
            // 
            textBox_filtraCI.Location = new Point(202, 45);
            textBox_filtraCI.Margin = new Padding(3, 2, 3, 2);
            textBox_filtraCI.Name = "textBox_filtraCI";
            textBox_filtraCI.Size = new Size(88, 23);
            textBox_filtraCI.TabIndex = 18;
            textBox_filtraCI.KeyDown += textBox_filtraCI_KeyDown;
            // 
            // textBox_filtraCM
            // 
            textBox_filtraCM.Location = new Point(202, 10);
            textBox_filtraCM.Margin = new Padding(3, 2, 3, 2);
            textBox_filtraCM.Name = "textBox_filtraCM";
            textBox_filtraCM.Size = new Size(88, 23);
            textBox_filtraCM.TabIndex = 17;
            textBox_filtraCM.KeyDown += textBox_filtraCM_KeyDown;
            // 
            // button_resetAmbulatori
            // 
            button_resetAmbulatori.Location = new Point(13, 392);
            button_resetAmbulatori.Margin = new Padding(3, 2, 3, 2);
            button_resetAmbulatori.Name = "button_resetAmbulatori";
            button_resetAmbulatori.Size = new Size(243, 22);
            button_resetAmbulatori.TabIndex = 31;
            button_resetAmbulatori.Text = "Vedi Tutti gli Ambulatori";
            button_resetAmbulatori.UseVisualStyleBackColor = true;
            button_resetAmbulatori.Click += button_resetAmbulatori_Click;
            // 
            // dataGridView_prenotazioni
            // 
            dataGridView_prenotazioni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_prenotazioni.Columns.AddRange(new DataGridViewColumn[] { label, Cancella, Modifica });
            dataGridView_prenotazioni.Location = new Point(570, 419);
            dataGridView_prenotazioni.Name = "dataGridView_prenotazioni";
            dataGridView_prenotazioni.Size = new Size(504, 211);
            dataGridView_prenotazioni.TabIndex = 32;
            dataGridView_prenotazioni.CellClick += dataGridView_prenotazioni_CellClick;
            // 
            // label
            // 
            label.HeaderText = "Prenotazione";
            label.Name = "label";
            label.Width = 350;
            // 
            // Cancella
            // 
            Cancella.Description = "Cancella Prenotazione";
            Cancella.HeaderText = "Canc.";
            Cancella.Image = Properties.Resources.x_mark_16;
            Cancella.Name = "Cancella";
            Cancella.ToolTipText = "Cancella Prenotazione";
            Cancella.Width = 40;
            // 
            // Modifica
            // 
            Modifica.Description = "Modifica Prenotazione";
            Modifica.HeaderText = "Mod.";
            Modifica.Image = Properties.Resources.edit_2_16;
            Modifica.Name = "Modifica";
            Modifica.ToolTipText = "Modifica Prenotazione";
            Modifica.Width = 40;
            // 
            // button_confermaPrenotazione
            // 
            button_confermaPrenotazione.Location = new Point(902, 390);
            button_confermaPrenotazione.Name = "button_confermaPrenotazione";
            button_confermaPrenotazione.Size = new Size(172, 23);
            button_confermaPrenotazione.TabIndex = 33;
            button_confermaPrenotazione.Text = "Conferma Prenotazione";
            button_confermaPrenotazione.UseVisualStyleBackColor = true;
            button_confermaPrenotazione.Click += button_confermaPrenotazione_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 433);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 36;
            label8.Text = "Ricerca Veloce:";
            // 
            // button_salvaRicerca
            // 
            button_salvaRicerca.Image = Properties.Resources.save_16;
            button_salvaRicerca.Location = new Point(141, 425);
            button_salvaRicerca.Name = "button_salvaRicerca";
            button_salvaRicerca.Size = new Size(30, 30);
            button_salvaRicerca.TabIndex = 37;
            button_salvaRicerca.UseVisualStyleBackColor = true;
            button_salvaRicerca.Click += button_salvaRicerca_Click;
            // 
            // button_getRicerca
            // 
            button_getRicerca.Image = Properties.Resources.arrow_204_16;
            button_getRicerca.Location = new Point(105, 425);
            button_getRicerca.Name = "button_getRicerca";
            button_getRicerca.Size = new Size(30, 30);
            button_getRicerca.TabIndex = 38;
            button_getRicerca.UseVisualStyleBackColor = true;
            button_getRicerca.Click += button_getRicerca_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 692);
            Controls.Add(button_getRicerca);
            Controls.Add(button_salvaRicerca);
            Controls.Add(label8);
            Controls.Add(button_confermaPrenotazione);
            Controls.Add(dataGridView_prenotazioni);
            Controls.Add(button_resetAmbulatori);
            Controls.Add(groupBox1);
            Controls.Add(listView_esami);
            Controls.Add(button_prenotaEsame);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonChiudi);
            Controls.Add(listBox_partiCorpo);
            Controls.Add(listBox_ambulatori);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Test NOLEX";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_prenotazioni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_ambulatori;
        private ListBox listBox_partiCorpo;
        private Button buttonChiudi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_prenotaEsame;
        private ListView listView_esami;
        private ColumnHeader CodiceMinisteriale;
        private ColumnHeader CodiceInterno;
        private ColumnHeader DescrizioneEsame;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox_filtraDescrizione;
        private TextBox textBox_filtraCI;
        private TextBox textBox_filtraCM;
        private Button button_filtraDescrizione;
        private Button button_filtroReset;
        private Button button_resetAmbulatori;
        private DataGridView dataGridView_prenotazioni;
        private DataGridViewTextBoxColumn label;
        private DataGridViewImageColumn Cancella;
        private DataGridViewImageColumn Modifica;
        private Button button_confermaPrenotazione;
        private Label label8;
        private Button button_salvaRicerca;
        private Button button_getRicerca;
    }
}
