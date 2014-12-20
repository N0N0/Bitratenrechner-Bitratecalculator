namespace BitratenrechnerCS
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
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Ziel_VidRate = new System.Windows.Forms.TextBox();
            this.Quelle_VidRate = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.Check1 = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Ziel_AudRate = new System.Windows.Forms.ComboBox();
            this.Quelle_AudRate = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Text_Sekunden = new System.Windows.Forms.TextBox();
            this.Text_Minuten = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Text_Stunden = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.Ziel_VidRate);
            this.GroupBox4.Controls.Add(this.Quelle_VidRate);
            this.GroupBox4.Location = new System.Drawing.Point(10, 85);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(170, 62);
            this.GroupBox4.TabIndex = 19;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Video-Bitrate";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Enabled = false;
            this.Label7.Location = new System.Drawing.Point(83, 14);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(24, 13);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Ziel";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(4, 14);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(37, 13);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Quelle";
            // 
            // Ziel_VidRate
            // 
            this.Ziel_VidRate.Enabled = false;
            this.Ziel_VidRate.Location = new System.Drawing.Point(86, 30);
            this.Ziel_VidRate.Name = "Ziel_VidRate";
            this.Ziel_VidRate.Size = new System.Drawing.Size(74, 20);
            this.Ziel_VidRate.TabIndex = 1;
            this.Ziel_VidRate.Text = "0";
            this.Ziel_VidRate.WordWrap = false;
            this.Ziel_VidRate.TextChanged += new System.EventHandler(this.Ziel_VidRate_TextChanged);
            // 
            // Quelle_VidRate
            // 
            this.Quelle_VidRate.Location = new System.Drawing.Point(6, 32);
            this.Quelle_VidRate.Name = "Quelle_VidRate";
            this.Quelle_VidRate.Size = new System.Drawing.Size(74, 20);
            this.Quelle_VidRate.TabIndex = 0;
            this.Quelle_VidRate.Text = "0";
            this.Quelle_VidRate.WordWrap = false;
            this.Quelle_VidRate.TextChanged += new System.EventHandler(this.Quelle_VidRate_TextChanged);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Text5);
            this.GroupBox3.Controls.Add(this.Check1);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(11, 244);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox3.Size = new System.Drawing.Size(170, 66);
            this.GroupBox3.TabIndex = 18;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Größe (MBytes)";
            // 
            // Text5
            // 
            this.Text5.BackColor = System.Drawing.SystemColors.Window;
            this.Text5.Location = new System.Drawing.Point(7, 14);
            this.Text5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(153, 21);
            this.Text5.TabIndex = 12;
            this.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Text5.WordWrap = false;
            this.Text5.TextChanged += new System.EventHandler(this.Text5_TextChanged);
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Check1.Location = new System.Drawing.Point(122, 42);
            this.Check1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(15, 14);
            this.Check1.TabIndex = 5;
            this.Check1.CheckedChanged += new System.EventHandler(this.Check1_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(8, 41);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Differenz ermitteln:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Ziel_AudRate);
            this.GroupBox2.Controls.Add(this.Quelle_AudRate);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(11, 153);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox2.Size = new System.Drawing.Size(170, 73);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Audio-Bitrate";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Enabled = false;
            this.Label8.Location = new System.Drawing.Point(83, 17);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(27, 15);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Ziel";
            // 
            // Ziel_AudRate
            // 
            this.Ziel_AudRate.Enabled = false;
            this.Ziel_AudRate.FormattingEnabled = true;
            this.Ziel_AudRate.Items.AddRange(new object[] {
            "32",
            "64",
            "80",
            "96",
            "112",
            "128",
            "160",
            "192",
            "224",
            "256",
            "320",
            "384"});
            this.Ziel_AudRate.Location = new System.Drawing.Point(86, 38);
            this.Ziel_AudRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ziel_AudRate.Name = "Ziel_AudRate";
            this.Ziel_AudRate.Size = new System.Drawing.Size(74, 23);
            this.Ziel_AudRate.TabIndex = 4;
            this.Ziel_AudRate.Text = "128";
            this.Ziel_AudRate.SelectedIndexChanged += new System.EventHandler(this.Ziel_AudRate_SelectedIndexChanged);
            this.Ziel_AudRate.TextChanged += new System.EventHandler(this.Ziel_AudRate_TextChanged);
            // 
            // Quelle_AudRate
            // 
            this.Quelle_AudRate.DisplayMember = "128";
            this.Quelle_AudRate.FormattingEnabled = true;
            this.Quelle_AudRate.Items.AddRange(new object[] {
            "112",
            "128",
            "160",
            "192",
            "224",
            "256",
            "32",
            "320",
            "384",
            "64",
            "80",
            "96"});
            this.Quelle_AudRate.Location = new System.Drawing.Point(11, 38);
            this.Quelle_AudRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Quelle_AudRate.Name = "Quelle_AudRate";
            this.Quelle_AudRate.Size = new System.Drawing.Size(69, 23);
            this.Quelle_AudRate.TabIndex = 3;
            this.Quelle_AudRate.Text = "128";
            this.Quelle_AudRate.SelectedIndexChanged += new System.EventHandler(this.Quelle_AudRate_SelectedIndexChanged);
            this.Quelle_AudRate.TextChanged += new System.EventHandler(this.Quelle_AudRate_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 15);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Quelle";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Text_Sekunden);
            this.GroupBox1.Controls.Add(this.Text_Minuten);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Text_Stunden);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(10, 7);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox1.Size = new System.Drawing.Size(171, 72);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Clip-Dauer";
            // 
            // Text_Sekunden
            // 
            this.Text_Sekunden.Location = new System.Drawing.Point(101, 36);
            this.Text_Sekunden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Text_Sekunden.MaxLength = 2;
            this.Text_Sekunden.Name = "Text_Sekunden";
            this.Text_Sekunden.Size = new System.Drawing.Size(23, 21);
            this.Text_Sekunden.TabIndex = 7;
            this.Text_Sekunden.Text = "00";
            this.Text_Sekunden.WordWrap = false;
            this.Text_Sekunden.TextChanged += new System.EventHandler(this.Text_Sekunden_TextChanged);
            // 
            // Text_Minuten
            // 
            this.Text_Minuten.Location = new System.Drawing.Point(58, 36);
            this.Text_Minuten.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Text_Minuten.MaxLength = 2;
            this.Text_Minuten.Name = "Text_Minuten";
            this.Text_Minuten.Size = new System.Drawing.Size(23, 21);
            this.Text_Minuten.TabIndex = 6;
            this.Text_Minuten.Text = "00";
            this.Text_Minuten.WordWrap = false;
            this.Text_Minuten.TextChanged += new System.EventHandler(this.Text_Minuten_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label5.Location = new System.Drawing.Point(15, 15);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(112, 15);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Std.      Min.      Sek.";
            // 
            // Text_Stunden
            // 
            this.Text_Stunden.Location = new System.Drawing.Point(18, 36);
            this.Text_Stunden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Text_Stunden.MaxLength = 2;
            this.Text_Stunden.Name = "Text_Stunden";
            this.Text_Stunden.Size = new System.Drawing.Size(23, 21);
            this.Text_Stunden.TabIndex = 5;
            this.Text_Stunden.Text = "00";
            this.Text_Stunden.WordWrap = false;
            this.Text_Stunden.TextChanged += new System.EventHandler(this.Text_Stunden_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(46, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 15);
            this.Label2.TabIndex = 8;
            this.Label2.Text = ":             :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 317);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BitratenRechnerC#";
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Ziel_VidRate;
        internal System.Windows.Forms.TextBox Quelle_VidRate;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox Text5;
        internal System.Windows.Forms.CheckBox Check1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox Ziel_AudRate;
        internal System.Windows.Forms.ComboBox Quelle_AudRate;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox Text_Sekunden;
        internal System.Windows.Forms.TextBox Text_Minuten;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Text_Stunden;
        internal System.Windows.Forms.Label Label2;


    }
}

