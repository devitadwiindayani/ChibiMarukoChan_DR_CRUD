namespace CRUDMahasiswaADO
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProdi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRecapDataMahasiswa = new System.Windows.Forms.Label();
            this.lblTahunMasuk = new System.Windows.Forms.Label();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.btnDataMahasiawa = new System.Windows.Forms.Button();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdi
            // 
            chartArea5.Name = "ChartArea1";
            this.chartProdi.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartProdi.Legends.Add(legend5);
            this.chartProdi.Location = new System.Drawing.Point(27, 95);
            this.chartProdi.Name = "chartProdi";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartProdi.Series.Add(series5);
            this.chartProdi.Size = new System.Drawing.Size(669, 413);
            this.chartProdi.TabIndex = 0;
            this.chartProdi.Text = "chart1";
            // 
            // lblRecapDataMahasiswa
            // 
            this.lblRecapDataMahasiswa.AutoSize = true;
            this.lblRecapDataMahasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapDataMahasiswa.Location = new System.Drawing.Point(264, 18);
            this.lblRecapDataMahasiswa.Name = "lblRecapDataMahasiswa";
            this.lblRecapDataMahasiswa.Size = new System.Drawing.Size(198, 16);
            this.lblRecapDataMahasiswa.TabIndex = 1;
            this.lblRecapDataMahasiswa.Text = "RECAP DATA MAHASISWA";
            // 
            // lblTahunMasuk
            // 
            this.lblTahunMasuk.AutoSize = true;
            this.lblTahunMasuk.Location = new System.Drawing.Point(47, 56);
            this.lblTahunMasuk.Name = "lblTahunMasuk";
            this.lblTahunMasuk.Size = new System.Drawing.Size(88, 16);
            this.lblTahunMasuk.TabIndex = 3;
            this.lblTahunMasuk.Text = "Tahun Masuk";
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(141, 56);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(174, 22);
            this.dtpTanggalMasuk.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(321, 56);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(402, 58);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDataMahasiawa
            // 
            this.btnDataMahasiawa.Location = new System.Drawing.Point(579, 527);
            this.btnDataMahasiawa.Name = "btnDataMahasiawa";
            this.btnDataMahasiawa.Size = new System.Drawing.Size(117, 23);
            this.btnDataMahasiawa.TabIndex = 9;
            this.btnDataMahasiawa.Text = "Data Mahasiswa";
            this.btnDataMahasiawa.UseVisualStyleBackColor = true;
            this.btnDataMahasiawa.Click += new System.EventHandler(this.btnDataMahasiawa_Click);
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Location = new System.Drawing.Point(575, 53);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(121, 24);
            this.cmbTipe.TabIndex = 10;
            this.cmbTipe.SelectedIndexChanged += new System.EventHandler(this.cmbTipe_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 574);
            this.Controls.Add(this.cmbTipe);
            this.Controls.Add(this.btnDataMahasiawa);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.lblTahunMasuk);
            this.Controls.Add(this.lblRecapDataMahasiswa);
            this.Controls.Add(this.chartProdi);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdi;
        private System.Windows.Forms.Label lblRecapDataMahasiswa;
        private System.Windows.Forms.Label lblTahunMasuk;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button btnDataMahasiawa;
        private System.Windows.Forms.ComboBox cmbTipe;
    }
}