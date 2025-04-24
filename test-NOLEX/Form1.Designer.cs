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
            button_confermaEsame = new Button();
            label4 = new Label();
            textBox_DB = new TextBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            listView_esami = new ListView();
            CodiceMinisteriale = new ColumnHeader();
            CodiceInterno = new ColumnHeader();
            DescrizioneEsame = new ColumnHeader();
            groupBox1 = new GroupBox();
            button_resetAmbulatori = new Button();
            button_filtroReset = new Button();
            button_filtraDescrizione = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox_filtraDescrizione = new TextBox();
            textBox_filtraCI = new TextBox();
            textBox_filtraCM = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_ambulatori
            // 
            listBox_ambulatori.FormattingEnabled = true;
            listBox_ambulatori.Location = new Point(10, 68);
            listBox_ambulatori.Margin = new Padding(3, 2, 3, 2);
            listBox_ambulatori.Name = "listBox_ambulatori";
            listBox_ambulatori.Size = new Size(201, 334);
            listBox_ambulatori.TabIndex = 0;
            listBox_ambulatori.SelectedValueChanged += listBox_ambulatori_SelectedValueChanged;
            // 
            // listBox_partiCorpo
            // 
            listBox_partiCorpo.FormattingEnabled = true;
            listBox_partiCorpo.Location = new Point(216, 68);
            listBox_partiCorpo.Margin = new Padding(3, 2, 3, 2);
            listBox_partiCorpo.Name = "listBox_partiCorpo";
            listBox_partiCorpo.Size = new Size(237, 334);
            listBox_partiCorpo.TabIndex = 1;
            listBox_partiCorpo.SelectedIndexChanged += listBox_partiCorpo_SelectedIndexChanged;
            // 
            // buttonChiudi
            // 
            buttonChiudi.Location = new Point(643, 438);
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
            label1.Location = new Point(74, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Ambulatori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(290, 44);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Parti del Corpo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(634, 44);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Esami";
            // 
            // button_confermaEsame
            // 
            button_confermaEsame.Location = new Point(458, 405);
            button_confermaEsame.Margin = new Padding(3, 2, 3, 2);
            button_confermaEsame.Name = "button_confermaEsame";
            button_confermaEsame.Size = new Size(438, 22);
            button_confermaEsame.TabIndex = 8;
            button_confermaEsame.Text = "Conferma Esame";
            button_confermaEsame.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 12);
            label4.Name = "label4";
            label4.Size = new Size(175, 15);
            label4.TabIndex = 9;
            label4.Text = "Seleziona il DB (database.sqlite):";
            // 
            // textBox_DB
            // 
            textBox_DB.Location = new Point(194, 9);
            textBox_DB.Margin = new Padding(3, 2, 3, 2);
            textBox_DB.Name = "textBox_DB";
            textBox_DB.Size = new Size(601, 23);
            textBox_DB.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(801, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(35, 22);
            button1.TabIndex = 11;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_fileDB_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView_esami
            // 
            listView_esami.Columns.AddRange(new ColumnHeader[] { CodiceMinisteriale, CodiceInterno, DescrizioneEsame });
            listView_esami.Location = new Point(470, 68);
            listView_esami.Margin = new Padding(3, 2, 3, 2);
            listView_esami.Name = "listView_esami";
            listView_esami.Size = new Size(362, 334);
            listView_esami.TabIndex = 12;
            listView_esami.UseCompatibleStateImageBehavior = false;
            listView_esami.ItemSelectionChanged += listView_esami_ItemSelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_resetAmbulatori);
            groupBox1.Controls.Add(button_filtroReset);
            groupBox1.Controls.Add(button_filtraDescrizione);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_filtraDescrizione);
            groupBox1.Controls.Add(textBox_filtraCI);
            groupBox1.Controls.Add(textBox_filtraCM);
            groupBox1.Location = new Point(849, 68);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(304, 333);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtra Esami";
            // 
            // button_resetAmbulatori
            // 
            button_resetAmbulatori.Location = new Point(139, 199);
            button_resetAmbulatori.Margin = new Padding(3, 2, 3, 2);
            button_resetAmbulatori.Name = "button_resetAmbulatori";
            button_resetAmbulatori.Size = new Size(151, 22);
            button_resetAmbulatori.TabIndex = 30;
            button_resetAmbulatori.Text = "Vedi Tutti gli Ambulatori";
            button_resetAmbulatori.UseVisualStyleBackColor = true;
            button_resetAmbulatori.Click += button_resetAmbulatori_Click;
            // 
            // button_filtroReset
            // 
            button_filtroReset.Location = new Point(139, 173);
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
            button_filtraDescrizione.Location = new Point(202, 130);
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
            label7.Location = new Point(40, 101);
            label7.Name = "label7";
            label7.Size = new Size(156, 15);
            label7.TabIndex = 23;
            label7.Text = "Filtra per Descrizione Esame:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 71);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 22;
            label6.Text = "Filtra per Codice Interno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 36);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 21;
            label5.Text = "Filtra per Codice Ministeriale:";
            // 
            // textBox_filtraDescrizione
            // 
            textBox_filtraDescrizione.Location = new Point(202, 98);
            textBox_filtraDescrizione.Margin = new Padding(3, 2, 3, 2);
            textBox_filtraDescrizione.Name = "textBox_filtraDescrizione";
            textBox_filtraDescrizione.Size = new Size(88, 23);
            textBox_filtraDescrizione.TabIndex = 19;
            textBox_filtraDescrizione.KeyDown += textBox_filtraDescrizione_KeyDown;
            // 
            // textBox_filtraCI
            // 
            textBox_filtraCI.Location = new Point(202, 68);
            textBox_filtraCI.Margin = new Padding(3, 2, 3, 2);
            textBox_filtraCI.Name = "textBox_filtraCI";
            textBox_filtraCI.Size = new Size(88, 23);
            textBox_filtraCI.TabIndex = 18;
            textBox_filtraCI.KeyDown += textBox_filtraCI_KeyDown;
            // 
            // textBox_filtraCM
            // 
            textBox_filtraCM.Location = new Point(202, 33);
            textBox_filtraCM.Margin = new Padding(3, 2, 3, 2);
            textBox_filtraCM.Name = "textBox_filtraCM";
            textBox_filtraCM.Size = new Size(88, 23);
            textBox_filtraCM.TabIndex = 17;
            textBox_filtraCM.KeyDown += textBox_filtraCM_KeyDown;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 469);
            Controls.Add(groupBox1);
            Controls.Add(listView_esami);
            Controls.Add(button1);
            Controls.Add(textBox_DB);
            Controls.Add(label4);
            Controls.Add(button_confermaEsame);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonChiudi);
            Controls.Add(listBox_partiCorpo);
            Controls.Add(listBox_ambulatori);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Test NOLEX";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button button_confermaEsame;
        private Label label4;
        private TextBox textBox_DB;
        private Button button1;
        private OpenFileDialog openFileDialog1;
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
    }
}
