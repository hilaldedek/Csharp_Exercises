namespace game_WindowsFormApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIrk = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtSilah = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.wolfman = new System.Windows.Forms.PictureBox();
            this.labelHealth = new System.Windows.Forms.Label();
            this.btnAttact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wolfman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Irk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Silah:";
            // 
            // cmbIrk
            // 
            this.cmbIrk.FormattingEnabled = true;
            this.cmbIrk.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbIrk.Location = new System.Drawing.Point(141, 46);
            this.cmbIrk.Name = "cmbIrk";
            this.cmbIrk.Size = new System.Drawing.Size(71, 24);
            this.cmbIrk.TabIndex = 6;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assasin"});
            this.cmbBrans.Location = new System.Drawing.Point(141, 79);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(71, 24);
            this.cmbBrans.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(141, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(71, 22);
            this.txtUserName.TabIndex = 8;
            // 
            // txtSilah
            // 
            this.txtSilah.Location = new System.Drawing.Point(141, 115);
            this.txtSilah.Name = "txtSilah";
            this.txtSilah.Size = new System.Drawing.Size(71, 22);
            this.txtSilah.TabIndex = 9;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(100, 166);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // wolfman
            // 
            this.wolfman.Image = global::game_WindowsFormApp3.Properties.Resources.kurtadam;
            this.wolfman.Location = new System.Drawing.Point(444, 115);
            this.wolfman.Name = "wolfman";
            this.wolfman.Size = new System.Drawing.Size(185, 99);
            this.wolfman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolfman.TabIndex = 11;
            this.wolfman.TabStop = false;
            this.wolfman.Visible = false;
            // 
            // labelHealth
            // 
            this.labelHealth.BackColor = System.Drawing.Color.DarkRed;
            this.labelHealth.Location = new System.Drawing.Point(444, 241);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(185, 23);
            this.labelHealth.TabIndex = 12;
            this.labelHealth.Visible = false;
            // 
            // btnAttact
            // 
            this.btnAttact.Location = new System.Drawing.Point(472, 54);
            this.btnAttact.Name = "btnAttact";
            this.btnAttact.Size = new System.Drawing.Size(113, 35);
            this.btnAttact.TabIndex = 13;
            this.btnAttact.Text = "Saldır";
            this.btnAttact.UseVisualStyleBackColor = true;
            this.btnAttact.Click += new System.EventHandler(this.btnAttact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAttact);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.wolfman);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSilah);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.cmbIrk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wolfman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIrk;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSilah;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox wolfman;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Button btnAttact;
    }
}

