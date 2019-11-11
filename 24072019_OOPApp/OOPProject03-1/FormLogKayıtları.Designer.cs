namespace OOPProject03_1
{
    partial class FormLogKayıtları
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.btnOkLog = new System.Windows.Forms.Button();
            this.collLogInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collLogInfo});
            this.dataGridViewLog.Location = new System.Drawing.Point(30, 27);
            this.dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewLog.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLog.Size = new System.Drawing.Size(896, 348);
            this.dataGridViewLog.TabIndex = 0;
            // 
            // btnOkLog
            // 
            this.btnOkLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOkLog.Location = new System.Drawing.Point(387, 390);
            this.btnOkLog.Name = "btnOkLog";
            this.btnOkLog.Size = new System.Drawing.Size(191, 48);
            this.btnOkLog.TabIndex = 1;
            this.btnOkLog.Text = "OK";
            this.btnOkLog.UseVisualStyleBackColor = true;
            this.btnOkLog.Click += new System.EventHandler(this.btnOkLog_Click);
            // 
            // collLogInfo
            // 
            this.collLogInfo.HeaderText = "Log Kayıt Bilgileri";
            this.collLogInfo.Name = "collLogInfo";
            // 
            // FormLogKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnOkLog);
            this.Controls.Add(this.dataGridViewLog);
            this.Name = "FormLogKayıtları";
            this.Text = "Log Kayıtları Listesi";
            this.Load += new System.EventHandler(this.FormLogKayıtları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.Button btnOkLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn collLogInfo;
    }
}