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
            listBox_esami = new ListBox();
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
            SuspendLayout();
            // 
            // listBox_ambulatori
            // 
            listBox_ambulatori.FormattingEnabled = true;
            listBox_ambulatori.Location = new Point(12, 130);
            listBox_ambulatori.Name = "listBox_ambulatori";
            listBox_ambulatori.Size = new Size(260, 404);
            listBox_ambulatori.TabIndex = 0;
            listBox_ambulatori.SelectedValueChanged += listBox_ambulatori_SelectedValueChanged;
            // 
            // listBox_partiCorpo
            // 
            listBox_partiCorpo.FormattingEnabled = true;
            listBox_partiCorpo.Location = new Point(289, 130);
            listBox_partiCorpo.Name = "listBox_partiCorpo";
            listBox_partiCorpo.Size = new Size(270, 404);
            listBox_partiCorpo.TabIndex = 1;
            // 
            // listBox_esami
            // 
            listBox_esami.FormattingEnabled = true;
            listBox_esami.Location = new Point(579, 130);
            listBox_esami.Name = "listBox_esami";
            listBox_esami.Size = new Size(250, 404);
            listBox_esami.TabIndex = 2;
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
            button_DB.Location = new Point(735, 12);
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
            label1.Location = new Point(93, 93);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Ambulatori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(378, 93);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Parti del Corpo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(692, 93);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Esami";
            // 
            // button_confermaEsame
            // 
            button_confermaEsame.Location = new Point(579, 540);
            button_confermaEsame.Name = "button_confermaEsame";
            button_confermaEsame.Size = new Size(250, 29);
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
            textBox_DB.Size = new Size(406, 27);
            textBox_DB.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(659, 11);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 625);
            Controls.Add(button1);
            Controls.Add(textBox_DB);
            Controls.Add(label4);
            Controls.Add(button_confermaEsame);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_DB);
            Controls.Add(buttonChiudi);
            Controls.Add(listBox_esami);
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
        private ListBox listBox_esami;
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
    }
}
