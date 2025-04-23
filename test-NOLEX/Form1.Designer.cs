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
            button_DB = new Button();
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
            textBox_filtraCM = new TextBox();
            textBox_filtraCI = new TextBox();
            textBox_filtraDescrizione = new TextBox();
            textBox_filtra = new TextBox();
            SuspendLayout();
            // 
            // listBox_ambulatori
            // 
            listBox_ambulatori.FormattingEnabled = true;
            listBox_ambulatori.Location = new Point(12, 90);
            listBox_ambulatori.Name = "listBox_ambulatori";
            listBox_ambulatori.Size = new Size(260, 444);
            listBox_ambulatori.TabIndex = 0;
            listBox_ambulatori.SelectedValueChanged += listBox_ambulatori_SelectedValueChanged;
            // 
            // listBox_partiCorpo
            // 
            listBox_partiCorpo.FormattingEnabled = true;
            listBox_partiCorpo.Location = new Point(289, 90);
            listBox_partiCorpo.Name = "listBox_partiCorpo";
            listBox_partiCorpo.Size = new Size(270, 444);
            listBox_partiCorpo.TabIndex = 1;
            listBox_partiCorpo.SelectedIndexChanged += listBox_partiCorpo_SelectedIndexChanged;
            // 
            // buttonChiudi
            // 
            buttonChiudi.Location = new Point(735, 584);
            buttonChiudi.Name = "buttonChiudi";
            buttonChiudi.Size = new Size(94, 29);
            buttonChiudi.TabIndex = 3;
            buttonChiudi.Text = "Chiudi";
            buttonChiudi.UseVisualStyleBackColor = true;
            buttonChiudi.Click += buttonChiudi_Click;
            // 
            // button_DB
            // 
            button_DB.Location = new Point(985, 11);
            button_DB.Name = "button_DB";
            button_DB.Size = new Size(94, 29);
            button_DB.TabIndex = 4;
            button_DB.Text = "Collega DB";
            button_DB.UseVisualStyleBackColor = true;
            button_DB.Click += button_DB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(94, 58);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Ambulatori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(379, 58);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Parti del Corpo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(817, 58);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Esami";
            // 
            // button_confermaEsame
            // 
            button_confermaEsame.Location = new Point(579, 540);
            button_confermaEsame.Name = "button_confermaEsame";
            button_confermaEsame.Size = new Size(500, 29);
            button_confermaEsame.TabIndex = 8;
            button_confermaEsame.Text = "Conferma Esame";
            button_confermaEsame.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 16);
            label4.Name = "label4";
            label4.Size = new Size(226, 20);
            label4.TabIndex = 9;
            label4.Text = "Seleziona il DB (database.sqlite):";
            // 
            // textBox_DB
            // 
            textBox_DB.Location = new Point(247, 13);
            textBox_DB.Name = "textBox_DB";
            textBox_DB.Size = new Size(686, 27);
            textBox_DB.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(939, 11);
            button1.Name = "button1";
            button1.Size = new Size(40, 29);
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
            listView_esami.Location = new Point(579, 163);
            listView_esami.Name = "listView_esami";
            listView_esami.Size = new Size(500, 371);
            listView_esami.TabIndex = 12;
            listView_esami.UseCompatibleStateImageBehavior = false;
            // 
            // textBox_filtraCM
            // 
            textBox_filtraCM.Location = new Point(580, 130);
            textBox_filtraCM.Name = "textBox_filtraCM";
            textBox_filtraCM.Size = new Size(97, 27);
            textBox_filtraCM.TabIndex = 13;
            textBox_filtraCM.TextChanged += textBox_filtraCM_TextChanged;
            // 
            // textBox_filtraCI
            // 
            textBox_filtraCI.Location = new Point(683, 130);
            textBox_filtraCI.Name = "textBox_filtraCI";
            textBox_filtraCI.Size = new Size(100, 27);
            textBox_filtraCI.TabIndex = 14;
            // 
            // textBox_filtraDescrizione
            // 
            textBox_filtraDescrizione.Location = new Point(789, 130);
            textBox_filtraDescrizione.Name = "textBox_filtraDescrizione";
            textBox_filtraDescrizione.Size = new Size(290, 27);
            textBox_filtraDescrizione.TabIndex = 15;
            textBox_filtraDescrizione.TextChanged += textBox_filtraDescrizione_TextChanged;
            // 
            // textBox_filtra
            // 
            textBox_filtra.Location = new Point(580, 90);
            textBox_filtra.Name = "textBox_filtra";
            textBox_filtra.Size = new Size(499, 27);
            textBox_filtra.TabIndex = 16;
            textBox_filtra.TextChanged += textBox_filtra_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 625);
            Controls.Add(textBox_filtra);
            Controls.Add(textBox_filtraDescrizione);
            Controls.Add(textBox_filtraCI);
            Controls.Add(textBox_filtraCM);
            Controls.Add(listView_esami);
            Controls.Add(button1);
            Controls.Add(textBox_DB);
            Controls.Add(label4);
            Controls.Add(button_confermaEsame);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_DB);
            Controls.Add(buttonChiudi);
            Controls.Add(listBox_partiCorpo);
            Controls.Add(listBox_ambulatori);
            Name = "FormMain";
            Text = "Test NOLEX";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_ambulatori;
        private ListBox listBox_partiCorpo;
        private Button buttonChiudi;
        private Button button_DB;
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
        private TextBox textBox_filtraCM;
        private TextBox textBox_filtraCI;
        private TextBox textBox_filtraDescrizione;
        private TextBox textBox_filtra;
    }
}
