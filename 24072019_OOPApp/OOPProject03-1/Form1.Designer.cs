namespace OOPProject03_1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUretveDoldur = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.btnTekliSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnCokluSil = new System.Windows.Forms.Button();
            this.btnSonIslemGeriAl = new System.Windows.Forms.Button();
            this.btnLogListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnUretveDoldur
            // 
            this.btnUretveDoldur.AllowDrop = true;
            this.btnUretveDoldur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUretveDoldur.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUretveDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUretveDoldur.Location = new System.Drawing.Point(62, 404);
            this.btnUretveDoldur.Name = "btnUretveDoldur";
            this.btnUretveDoldur.Size = new System.Drawing.Size(134, 34);
            this.btnUretveDoldur.TabIndex = 1;
            this.btnUretveDoldur.Text = "Üret ve Doldur";
            this.btnUretveDoldur.UseVisualStyleBackColor = false;
            this.btnUretveDoldur.Click += new System.EventHandler(this.btnUretveDoldur_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetay.Location = new System.Drawing.Point(214, 404);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(109, 34);
            this.btnDetay.TabIndex = 2;
            this.btnDetay.Text = "Detaylandır";
            this.btnDetay.UseVisualStyleBackColor = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVeriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriEkle.Location = new System.Drawing.Point(339, 404);
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.Size = new System.Drawing.Size(80, 34);
            this.btnVeriEkle.TabIndex = 3;
            this.btnVeriEkle.Text = "Ekle";
            this.btnVeriEkle.UseVisualStyleBackColor = false;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click);
            // 
            // btnTekliSil
            // 
            this.btnTekliSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekliSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTekliSil.Location = new System.Drawing.Point(435, 404);
            this.btnTekliSil.Name = "btnTekliSil";
            this.btnTekliSil.Size = new System.Drawing.Size(99, 34);
            this.btnTekliSil.TabIndex = 4;
            this.btnTekliSil.Text = "Tekli Sil";
            this.btnTekliSil.UseVisualStyleBackColor = true;
            this.btnTekliSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(699, 404);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(128, 34);
            this.btnDegistir.TabIndex = 5;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnCokluSil
            // 
            this.btnCokluSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCokluSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCokluSil.Location = new System.Drawing.Point(555, 404);
            this.btnCokluSil.Name = "btnCokluSil";
            this.btnCokluSil.Size = new System.Drawing.Size(116, 34);
            this.btnCokluSil.TabIndex = 6;
            this.btnCokluSil.Text = "Çoklu Sil";
            this.btnCokluSil.UseVisualStyleBackColor = false;
            this.btnCokluSil.Click += new System.EventHandler(this.btnCokluSil_Click);
            // 
            // btnSonIslemGeriAl
            // 
            this.btnSonIslemGeriAl.Enabled = false;
            this.btnSonIslemGeriAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonIslemGeriAl.Location = new System.Drawing.Point(716, 100);
            this.btnSonIslemGeriAl.Name = "btnSonIslemGeriAl";
            this.btnSonIslemGeriAl.Size = new System.Drawing.Size(111, 84);
            this.btnSonIslemGeriAl.TabIndex = 7;
            this.btnSonIslemGeriAl.Text = "Son İşlemi \r\nGeri Al";
            this.btnSonIslemGeriAl.UseVisualStyleBackColor = true;
            this.btnSonIslemGeriAl.Click += new System.EventHandler(this.btnSonIslemGeriAl_Click);
            // 
            // btnLogListele
            // 
            this.btnLogListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogListele.Location = new System.Drawing.Point(716, 230);
            this.btnLogListele.Name = "btnLogListele";
            this.btnLogListele.Size = new System.Drawing.Size(111, 83);
            this.btnLogListele.TabIndex = 8;
            this.btnLogListele.Text = "Log Kayıtlarını Listele";
            this.btnLogListele.UseVisualStyleBackColor = false;
            this.btnLogListele.Click += new System.EventHandler(this.btnLogListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.btnLogListele);
            this.Controls.Add(this.btnSonIslemGeriAl);
            this.Controls.Add(this.btnCokluSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnTekliSil);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnUretveDoldur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Verileri Otomatik Üret ve Doldur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUretveDoldur;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Button btnTekliSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnCokluSil;
        private System.Windows.Forms.Button btnSonIslemGeriAl;
        private System.Windows.Forms.Button btnLogListele;
    }
}

