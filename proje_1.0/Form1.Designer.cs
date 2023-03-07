namespace proje_1._0
{
    partial class Form1
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
            this.mailButton = new System.Windows.Forms.Button();
            this.nabizLabel = new System.Windows.Forms.Label();
            this.SicaklikLabel = new System.Windows.Forms.Label();
            this.LDRLabel = new System.Windows.Forms.Label();
            this.fanClose = new System.Windows.Forms.Button();
            this.fanLow = new System.Windows.Forms.Button();
            this.fanHigh = new System.Windows.Forms.Button();
            this.ldrHigh = new System.Windows.Forms.Button();
            this.ldrLow = new System.Windows.Forms.Button();
            this.ldrClose = new System.Windows.Forms.Button();
            this.photoButton = new System.Windows.Forms.Button();
            this.textBox_alert = new System.Windows.Forms.TextBox();
            this.buzzerClose = new System.Windows.Forms.Button();
            this.buzzerLow = new System.Windows.Forms.Button();
            this.buzzerHigh = new System.Windows.Forms.Button();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LDRLabell = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.roleOpen = new System.Windows.Forms.Button();
            this.roleClose = new System.Windows.Forms.Button();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mailButton
            // 
            this.mailButton.Location = new System.Drawing.Point(325, 105);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(103, 29);
            this.mailButton.TabIndex = 0;
            this.mailButton.Text = "Mail Gönder";
            this.mailButton.UseVisualStyleBackColor = true;
            this.mailButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nabizLabel
            // 
            this.nabizLabel.AutoSize = true;
            this.nabizLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nabizLabel.Location = new System.Drawing.Point(78, 37);
            this.nabizLabel.Name = "nabizLabel";
            this.nabizLabel.Size = new System.Drawing.Size(190, 45);
            this.nabizLabel.TabIndex = 1;
            this.nabizLabel.Text = "Nabız Verisi";
            // 
            // SicaklikLabel
            // 
            this.SicaklikLabel.AutoSize = true;
            this.SicaklikLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SicaklikLabel.Location = new System.Drawing.Point(78, 167);
            this.SicaklikLabel.Name = "SicaklikLabel";
            this.SicaklikLabel.Size = new System.Drawing.Size(212, 45);
            this.SicaklikLabel.TabIndex = 2;
            this.SicaklikLabel.Text = "Sicaklik Verisi";
            // 
            // LDRLabel
            // 
            this.LDRLabel.Location = new System.Drawing.Point(0, 0);
            this.LDRLabel.Name = "LDRLabel";
            this.LDRLabel.Size = new System.Drawing.Size(101, 23);
            this.LDRLabel.TabIndex = 20;
            // 
            // fanClose
            // 
            this.fanClose.Location = new System.Drawing.Point(82, 249);
            this.fanClose.Name = "fanClose";
            this.fanClose.Size = new System.Drawing.Size(107, 29);
            this.fanClose.TabIndex = 5;
            this.fanClose.Text = "Fan Kapat";
            this.fanClose.UseVisualStyleBackColor = true;
            this.fanClose.Click += new System.EventHandler(this.fanClose_Click);
            // 
            // fanLow
            // 
            this.fanLow.Location = new System.Drawing.Point(203, 249);
            this.fanLow.Name = "fanLow";
            this.fanLow.Size = new System.Drawing.Size(105, 29);
            this.fanLow.TabIndex = 6;
            this.fanLow.Text = "Düşük Hız";
            this.fanLow.UseVisualStyleBackColor = true;
            this.fanLow.Click += new System.EventHandler(this.fanLow_Click);
            // 
            // fanHigh
            // 
            this.fanHigh.Location = new System.Drawing.Point(325, 249);
            this.fanHigh.Name = "fanHigh";
            this.fanHigh.Size = new System.Drawing.Size(104, 29);
            this.fanHigh.TabIndex = 7;
            this.fanHigh.Text = "Yüksek Hız";
            this.fanHigh.UseVisualStyleBackColor = true;
            this.fanHigh.Click += new System.EventHandler(this.fanHigh_Click);
            // 
            // ldrHigh
            // 
            this.ldrHigh.Location = new System.Drawing.Point(325, 450);
            this.ldrHigh.Name = "ldrHigh";
            this.ldrHigh.Size = new System.Drawing.Size(104, 29);
            this.ldrHigh.TabIndex = 10;
            this.ldrHigh.Text = "Yüksek Işık";
            this.ldrHigh.UseVisualStyleBackColor = true;
            this.ldrHigh.Click += new System.EventHandler(this.ldrHigh_Click);
            // 
            // ldrLow
            // 
            this.ldrLow.Location = new System.Drawing.Point(203, 450);
            this.ldrLow.Name = "ldrLow";
            this.ldrLow.Size = new System.Drawing.Size(105, 29);
            this.ldrLow.TabIndex = 9;
            this.ldrLow.Text = "Düşük Işık";
            this.ldrLow.UseVisualStyleBackColor = true;
            this.ldrLow.Click += new System.EventHandler(this.ldrLow_Click_1);
            // 
            // ldrClose
            // 
            this.ldrClose.Location = new System.Drawing.Point(82, 450);
            this.ldrClose.Name = "ldrClose";
            this.ldrClose.Size = new System.Drawing.Size(107, 29);
            this.ldrClose.TabIndex = 8;
            this.ldrClose.Text = "Ampül Kapat";
            this.ldrClose.UseVisualStyleBackColor = true;
            this.ldrClose.Click += new System.EventHandler(this.ldrLow_Click);
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(654, 376);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(115, 44);
            this.photoButton.TabIndex = 11;
            this.photoButton.Text = "Fotoğraf Çek";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_alert
            // 
            this.textBox_alert.BackColor = System.Drawing.Color.MintCream;
            this.textBox_alert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_alert.ForeColor = System.Drawing.Color.Red;
            this.textBox_alert.Location = new System.Drawing.Point(503, 437);
            this.textBox_alert.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBox_alert.MaximumSize = new System.Drawing.Size(1142, 1332);
            this.textBox_alert.MaxLength = 20;
            this.textBox_alert.Multiline = true;
            this.textBox_alert.Name = "textBox_alert";
            this.textBox_alert.ReadOnly = true;
            this.textBox_alert.Size = new System.Drawing.Size(423, 143);
            this.textBox_alert.TabIndex = 12;
            this.textBox_alert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buzzerClose
            // 
            this.buzzerClose.Location = new System.Drawing.Point(82, 525);
            this.buzzerClose.Name = "buzzerClose";
            this.buzzerClose.Size = new System.Drawing.Size(107, 29);
            this.buzzerClose.TabIndex = 13;
            this.buzzerClose.Text = "Ses Kapat";
            this.buzzerClose.UseVisualStyleBackColor = true;
            this.buzzerClose.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buzzerLow
            // 
            this.buzzerLow.Location = new System.Drawing.Point(203, 525);
            this.buzzerLow.Name = "buzzerLow";
            this.buzzerLow.Size = new System.Drawing.Size(105, 29);
            this.buzzerLow.TabIndex = 14;
            this.buzzerLow.Text = "Düşük Ses";
            this.buzzerLow.UseVisualStyleBackColor = true;
            this.buzzerLow.Click += new System.EventHandler(this.buzzerLow_Click);
            // 
            // buzzerHigh
            // 
            this.buzzerHigh.Location = new System.Drawing.Point(325, 525);
            this.buzzerHigh.Name = "buzzerHigh";
            this.buzzerHigh.Size = new System.Drawing.Size(104, 29);
            this.buzzerHigh.TabIndex = 15;
            this.buzzerHigh.Text = "Yüksek Ses ";
            this.buzzerHigh.UseVisualStyleBackColor = true;
            this.buzzerHigh.Click += new System.EventHandler(this.buzzerHigh_Click);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(82, 105);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(207, 27);
            this.mailBox.TabIndex = 16;
            this.mailBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mailBox_MouseClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Location = new System.Drawing.Point(503, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(424, 323);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click_1);
            // 
            // LDRLabell
            // 
            this.LDRLabell.AutoSize = true;
            this.LDRLabell.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LDRLabell.Location = new System.Drawing.Point(82, 376);
            this.LDRLabell.Name = "LDRLabell";
            this.LDRLabell.Size = new System.Drawing.Size(153, 45);
            this.LDRLabell.TabIndex = 19;
            this.LDRLabell.Text = "Işık Verisi";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartButton.Location = new System.Drawing.Point(974, 29);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(138, 81);
            this.StartButton.TabIndex = 21;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(974, 139);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(138, 77);
            this.StopButton.TabIndex = 22;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // comboCOM
            // 
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Location = new System.Drawing.Point(974, 251);
            this.comboCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(138, 28);
            this.comboCOM.TabIndex = 23;
            // 
            // roleOpen
            // 
            this.roleOpen.Location = new System.Drawing.Point(279, 309);
            this.roleOpen.Name = "roleOpen";
            this.roleOpen.Size = new System.Drawing.Size(94, 29);
            this.roleOpen.TabIndex = 24;
            this.roleOpen.Text = "Isıtıcı Aç";
            this.roleOpen.UseVisualStyleBackColor = true;
            this.roleOpen.Click += new System.EventHandler(this.roleOpen_Click);
            // 
            // roleClose
            // 
            this.roleClose.Location = new System.Drawing.Point(129, 309);
            this.roleClose.Name = "roleClose";
            this.roleClose.Size = new System.Drawing.Size(94, 29);
            this.roleClose.TabIndex = 25;
            this.roleClose.Text = "Isıtıcı Kapat";
            this.roleClose.UseVisualStyleBackColor = true;
            this.roleClose.Click += new System.EventHandler(this.roleClose_Click);
            // 
            // comboBaud
            // 
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBaud.Location = new System.Drawing.Point(974, 324);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(138, 28);
            this.comboBaud.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1144, 615);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.roleClose);
            this.Controls.Add(this.roleOpen);
            this.Controls.Add(this.comboCOM);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LDRLabell);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.buzzerHigh);
            this.Controls.Add(this.buzzerLow);
            this.Controls.Add(this.buzzerClose);
            this.Controls.Add(this.textBox_alert);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.ldrHigh);
            this.Controls.Add(this.ldrLow);
            this.Controls.Add(this.ldrClose);
            this.Controls.Add(this.fanHigh);
            this.Controls.Add(this.fanLow);
            this.Controls.Add(this.fanClose);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.LDRLabel);
            this.Controls.Add(this.SicaklikLabel);
            this.Controls.Add(this.nabizLabel);
            this.Controls.Add(this.mailButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mailButton;
        private Label nabizLabel;
        private Label SicaklikLabel;
        private Label LDRLabel;
        private Button fanClose;
        private Button fanLow;
        private Button fanHigh;
        private Button ldrHigh;
        private Button ldrLow;
        private Button ldrClose;
        private Button photoButton;
        private TextBox textBox_alert;
        private Button buzzerClose;
        private Button buzzerLow;
        private Button buzzerHigh;
        private TextBox mailBox;
        private PictureBox pictureBox;
        private Label LDRLabell;
        private Button StartButton;
        private Button StopButton;
        private ComboBox comboCOM;
        private Button roleOpen;
        private Button roleClose;
        private ComboBox comboBaud;
    }
}