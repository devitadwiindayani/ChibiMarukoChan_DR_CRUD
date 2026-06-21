namespace CRUDMahasiswaADO
{
    partial class RecapDataMahasiswa
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
            this.lblRecapDataMahasiswa = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblTahunMasuk = new System.Windows.Forms.Label();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecapDataMahasiswa
            // 
            this.lblRecapDataMahasiswa.AutoSize = true;
            this.lblRecapDataMahasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapDataMahasiswa.Location = new System.Drawing.Point(298, 9);
            this.lblRecapDataMahasiswa.Name = "lblRecapDataMahasiswa";
            this.lblRecapDataMahasiswa.Size = new System.Drawing.Size(198, 16);
            this.lblRecapDataMahasiswa.TabIndex = 0;
            this.lblRecapDataMahasiswa.Text = "RECAP DATA MAHASISWA";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(84, 40);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(39, 16);
            this.lblProdi.TabIndex = 1;
            this.lblProdi.Text = "Prodi";
            // 
            // lblTahunMasuk
            // 
            this.lblTahunMasuk.AutoSize = true;
            this.lblTahunMasuk.Location = new System.Drawing.Point(317, 41);
            this.lblTahunMasuk.Name = "lblTahunMasuk";
            this.lblTahunMasuk.Size = new System.Drawing.Size(88, 16);
            this.lblTahunMasuk.TabIndex = 2;
            this.lblTahunMasuk.Text = "Tahun Masuk";
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Location = new System.Drawing.Point(129, 37);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(182, 24);
            this.cmbProdi.TabIndex = 3;
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(411, 35);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalMasuk.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(628, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(713, 415);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 6;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 331);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RecapDataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.lblTahunMasuk);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblRecapDataMahasiswa);
            this.Name = "RecapDataMahasiswa";
            this.Text = "RecapDataMahasiswa";
            this.Load += new System.EventHandler(this.RecapDataMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecapDataMahasiswa;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.Label lblTahunMasuk;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}