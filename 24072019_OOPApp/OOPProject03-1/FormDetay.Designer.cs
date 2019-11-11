namespace OOPProject03_1
{
    partial class FormDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblToplamGun = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYasadiniz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtToplamGun = new System.Windows.Forms.TextBox();
            this.txtToplamSaat = new System.Windows.Forms.TextBox();
            this.txtToplamDk = new System.Windows.Forms.TextBox();
            this.txtToplamSaniye = new System.Windows.Forms.TextBox();
            this.txtToplamMilisaniye = new System.Windows.Forms.TextBox();
            this.lblDgmYeriDetay = new System.Windows.Forms.Label();
            this.cmbDgmYeriDetay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(102, 64);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(102, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(102, 163);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(28, 13);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "Yaş:";
            // 
            // lblToplamGun
            // 
            this.lblToplamGun.AutoSize = true;
            this.lblToplamGun.Location = new System.Drawing.Point(102, 194);
            this.lblToplamGun.Name = "lblToplamGun";
            this.lblToplamGun.Size = new System.Drawing.Size(68, 13);
            this.lblToplamGun.TabIndex = 1;
            this.lblToplamGun.Text = "Toplam Gün:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toplam Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Toplam Dakika:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Toplam Saniye:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Toplam Milisaniye:";
            // 
            // lblYasadiniz
            // 
            this.lblYasadiniz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblYasadiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasadiniz.Location = new System.Drawing.Point(105, 380);
            this.lblYasadiniz.Name = "lblYasadiniz";
            this.lblYasadiniz.Size = new System.Drawing.Size(250, 61);
            this.lblYasadiniz.TabIndex = 3;
            this.lblYasadiniz.Text = "***YAŞADINIZ***";
            this.lblYasadiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(214, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(214, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(141, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(214, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtYas
            // 
            this.txtYas.Enabled = false;
            this.txtYas.Location = new System.Drawing.Point(214, 160);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(141, 20);
            this.txtYas.TabIndex = 4;
            // 
            // txtToplamGun
            // 
            this.txtToplamGun.Enabled = false;
            this.txtToplamGun.Location = new System.Drawing.Point(214, 191);
            this.txtToplamGun.Name = "txtToplamGun";
            this.txtToplamGun.Size = new System.Drawing.Size(141, 20);
            this.txtToplamGun.TabIndex = 4;
            // 
            // txtToplamSaat
            // 
            this.txtToplamSaat.Enabled = false;
            this.txtToplamSaat.Location = new System.Drawing.Point(214, 228);
            this.txtToplamSaat.Name = "txtToplamSaat";
            this.txtToplamSaat.Size = new System.Drawing.Size(141, 20);
            this.txtToplamSaat.TabIndex = 4;
            // 
            // txtToplamDk
            // 
            this.txtToplamDk.Enabled = false;
            this.txtToplamDk.Location = new System.Drawing.Point(214, 265);
            this.txtToplamDk.Name = "txtToplamDk";
            this.txtToplamDk.Size = new System.Drawing.Size(141, 20);
            this.txtToplamDk.TabIndex = 4;
            // 
            // txtToplamSaniye
            // 
            this.txtToplamSaniye.Enabled = false;
            this.txtToplamSaniye.Location = new System.Drawing.Point(214, 307);
            this.txtToplamSaniye.Name = "txtToplamSaniye";
            this.txtToplamSaniye.Size = new System.Drawing.Size(141, 20);
            this.txtToplamSaniye.TabIndex = 4;
            // 
            // txtToplamMilisaniye
            // 
            this.txtToplamMilisaniye.Enabled = false;
            this.txtToplamMilisaniye.Location = new System.Drawing.Point(214, 349);
            this.txtToplamMilisaniye.Name = "txtToplamMilisaniye";
            this.txtToplamMilisaniye.Size = new System.Drawing.Size(141, 20);
            this.txtToplamMilisaniye.TabIndex = 4;
            // 
            // lblDgmYeriDetay
            // 
            this.lblDgmYeriDetay.AutoSize = true;
            this.lblDgmYeriDetay.Location = new System.Drawing.Point(102, 131);
            this.lblDgmYeriDetay.Name = "lblDgmYeriDetay";
            this.lblDgmYeriDetay.Size = new System.Drawing.Size(65, 13);
            this.lblDgmYeriDetay.TabIndex = 5;
            this.lblDgmYeriDetay.Text = "Doğum Yeri:";
            // 
            // cmbDgmYeriDetay
            // 
            this.cmbDgmYeriDetay.Enabled = false;
            this.cmbDgmYeriDetay.FormattingEnabled = true;
            this.cmbDgmYeriDetay.Location = new System.Drawing.Point(214, 128);
            this.cmbDgmYeriDetay.Name = "cmbDgmYeriDetay";
            this.cmbDgmYeriDetay.Size = new System.Drawing.Size(141, 21);
            this.cmbDgmYeriDetay.TabIndex = 6;
            // 
            // FormDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.cmbDgmYeriDetay);
            this.Controls.Add(this.lblDgmYeriDetay);
            this.Controls.Add(this.txtToplamMilisaniye);
            this.Controls.Add(this.txtToplamSaniye);
            this.Controls.Add(this.txtToplamDk);
            this.Controls.Add(this.txtToplamSaat);
            this.Controls.Add(this.txtToplamGun);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblYasadiniz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblToplamGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblId);
            this.Name = "FormDetay";
            this.Text = "Seçilen Kişinin Yaşam Süresi Bilgileri";
            this.Load += new System.EventHandler(this.FormDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblToplamGun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYasadiniz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtToplamGun;
        private System.Windows.Forms.TextBox txtToplamSaat;
        private System.Windows.Forms.TextBox txtToplamDk;
        private System.Windows.Forms.TextBox txtToplamSaniye;
        private System.Windows.Forms.TextBox txtToplamMilisaniye;
        private System.Windows.Forms.Label lblDgmYeriDetay;
        private System.Windows.Forms.ComboBox cmbDgmYeriDetay;
    }
}