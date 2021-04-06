namespace WBS_Kplus_SN
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbMitKomma = new System.Windows.Forms.RadioButton();
            this.rbOhneKomma = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxVorschau = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAnzahl = new System.Windows.Forms.Label();
            this.rbMitSn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMitKomma
            // 
            this.rbMitKomma.AutoSize = true;
            this.rbMitKomma.Checked = true;
            this.rbMitKomma.Location = new System.Drawing.Point(42, 211);
            this.rbMitKomma.Margin = new System.Windows.Forms.Padding(2);
            this.rbMitKomma.Name = "rbMitKomma";
            this.rbMitKomma.Size = new System.Drawing.Size(118, 17);
            this.rbMitKomma.TabIndex = 2;
            this.rbMitKomma.TabStop = true;
            this.rbMitKomma.Text = "mit Komma getrennt";
            this.rbMitKomma.UseVisualStyleBackColor = true;
            this.rbMitKomma.CheckedChanged += new System.EventHandler(this.rbMitKomma_CheckedChanged);
            this.rbMitKomma.Click += new System.EventHandler(this.rbMitKomma_Click);
            // 
            // rbOhneKomma
            // 
            this.rbOhneKomma.AutoSize = true;
            this.rbOhneKomma.Location = new System.Drawing.Point(42, 229);
            this.rbOhneKomma.Margin = new System.Windows.Forms.Padding(2);
            this.rbOhneKomma.Name = "rbOhneKomma";
            this.rbOhneKomma.Size = new System.Drawing.Size(129, 17);
            this.rbOhneKomma.TabIndex = 3;
            this.rbOhneKomma.Text = "ohne Komma getrennt";
            this.rbOhneKomma.UseVisualStyleBackColor = true;
            this.rbOhneKomma.CheckedChanged += new System.EventHandler(this.rbOhneKomma_CheckedChanged);
            this.rbOhneKomma.Click += new System.EventHandler(this.rbOhneKomma_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(42, 253);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 54);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SN-Textblock einfügen:";
            // 
            // lbxVorschau
            // 
            this.lbxVorschau.FormattingEnabled = true;
            this.lbxVorschau.Location = new System.Drawing.Point(330, 84);
            this.lbxVorschau.Margin = new System.Windows.Forms.Padding(2);
            this.lbxVorschau.Name = "lbxVorschau";
            this.lbxVorschau.Size = new System.Drawing.Size(182, 225);
            this.lbxVorschau.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vorschau SN-Liste:";
            // 
            // lbCountdown
            // 
            this.lbCountdown.AutoSize = true;
            this.lbCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.ForeColor = System.Drawing.Color.Red;
            this.lbCountdown.Location = new System.Drawing.Point(218, 229);
            this.lbCountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(69, 73);
            this.lbCountdown.TabIndex = 7;
            this.lbCountdown.Text = "5";
            this.lbCountdown.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 52);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 84);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 125);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ohne Gewähr! Kontrolliert sowohl in der Vorschauliste rechts, als auch am Ende in" +
    " der KPlus auf Korrektheit!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WBS_Kplus_SN.Properties.Resources.wbs_logoweissblau_klein;
            this.pictureBox1.Location = new System.Drawing.Point(400, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(496, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Paul B.";
            // 
            // lbAnzahl
            // 
            this.lbAnzahl.AutoSize = true;
            this.lbAnzahl.Location = new System.Drawing.Point(432, 70);
            this.lbAnzahl.Name = "lbAnzahl";
            this.lbAnzahl.Size = new System.Drawing.Size(13, 13);
            this.lbAnzahl.TabIndex = 13;
            this.lbAnzahl.Text = "0";
            // 
            // rbMitSn
            // 
            this.rbMitSn.AutoSize = true;
            this.rbMitSn.Location = new System.Drawing.Point(165, 211);
            this.rbMitSn.Name = "rbMitSn";
            this.rbMitSn.Size = new System.Drawing.Size(160, 17);
            this.rbMitSn.TabIndex = 4;
            this.rbMitSn.TabStop = true;
            this.rbMitSn.Text = "mit SN: und Komma getrennt";
            this.rbMitSn.UseVisualStyleBackColor = true;
            this.rbMitSn.CheckedChanged += new System.EventHandler(this.rbMitSn_CheckedChanged);
            this.rbMitSn.Click += new System.EventHandler(this.rbMitSn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 342);
            this.Controls.Add(this.rbMitSn);
            this.Controls.Add(this.lbAnzahl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCountdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxVorschau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbOhneKomma);
            this.Controls.Add(this.rbMitKomma);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbMitKomma;
        private System.Windows.Forms.RadioButton rbOhneKomma;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxVorschau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAnzahl;
        private System.Windows.Forms.RadioButton rbMitSn;
    }
}

