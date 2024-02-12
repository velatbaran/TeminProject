
namespace TeminProject
{
    partial class frmIstatistihCalisilanFirmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIstatistihCalisilanFirmalar));
            this.cmbIstatistikYil = new System.Windows.Forms.ComboBox();
            this.gridIstatistikTeminler = new System.Windows.Forms.DataGridView();
            this.SicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIstatistikFirmaGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistikTeminler)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIstatistikYil
            // 
            this.cmbIstatistikYil.FormattingEnabled = true;
            this.cmbIstatistikYil.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbIstatistikYil.Location = new System.Drawing.Point(362, 5);
            this.cmbIstatistikYil.Name = "cmbIstatistikYil";
            this.cmbIstatistikYil.Size = new System.Drawing.Size(79, 21);
            this.cmbIstatistikYil.TabIndex = 0;
            this.cmbIstatistikYil.Text = "seçiniz...";
            // 
            // gridIstatistikTeminler
            // 
            this.gridIstatistikTeminler.AllowUserToAddRows = false;
            this.gridIstatistikTeminler.AllowUserToDeleteRows = false;
            this.gridIstatistikTeminler.BackgroundColor = System.Drawing.Color.White;
            this.gridIstatistikTeminler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIstatistikTeminler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SicilNo,
            this.FirmaAd});
            this.gridIstatistikTeminler.Location = new System.Drawing.Point(1, 33);
            this.gridIstatistikTeminler.Name = "gridIstatistikTeminler";
            this.gridIstatistikTeminler.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridIstatistikTeminler.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridIstatistikTeminler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIstatistikTeminler.Size = new System.Drawing.Size(440, 252);
            this.gridIstatistikTeminler.TabIndex = 26;
            // 
            // SicilNo
            // 
            this.SicilNo.DataPropertyName = "SicilNo";
            this.SicilNo.HeaderText = "Sicil No";
            this.SicilNo.MinimumWidth = 100;
            this.SicilNo.Name = "SicilNo";
            this.SicilNo.ReadOnly = true;
            // 
            // FirmaAd
            // 
            this.FirmaAd.DataPropertyName = "FirmaAd";
            this.FirmaAd.HeaderText = "İşi Yapan Firma";
            this.FirmaAd.MinimumWidth = 300;
            this.FirmaAd.Name = "FirmaAd";
            this.FirmaAd.ReadOnly = true;
            this.FirmaAd.Width = 300;
            // 
            // btnIstatistikFirmaGetir
            // 
            this.btnIstatistikFirmaGetir.BackColor = System.Drawing.Color.Teal;
            this.btnIstatistikFirmaGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatistikFirmaGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistikFirmaGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistikFirmaGetir.ForeColor = System.Drawing.Color.White;
            this.btnIstatistikFirmaGetir.Image = ((System.Drawing.Image)(resources.GetObject("btnIstatistikFirmaGetir.Image")));
            this.btnIstatistikFirmaGetir.Location = new System.Drawing.Point(275, 2);
            this.btnIstatistikFirmaGetir.Name = "btnIstatistikFirmaGetir";
            this.btnIstatistikFirmaGetir.Size = new System.Drawing.Size(82, 30);
            this.btnIstatistikFirmaGetir.TabIndex = 33;
            this.btnIstatistikFirmaGetir.Text = "Getir";
            this.btnIstatistikFirmaGetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIstatistikFirmaGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIstatistikFirmaGetir.UseVisualStyleBackColor = false;
            this.btnIstatistikFirmaGetir.Click += new System.EventHandler(this.btnIstatistikFirmaGetir_Click);
            // 
            // frmIstatistihCalisilanFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(444, 287);
            this.Controls.Add(this.btnIstatistikFirmaGetir);
            this.Controls.Add(this.gridIstatistikTeminler);
            this.Controls.Add(this.cmbIstatistikYil);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIstatistihCalisilanFirmalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışılan Firmalar Sayfası";
            this.Load += new System.EventHandler(this.frmIstatistihCalisilanFirmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistikTeminler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIstatistikYil;
        public System.Windows.Forms.DataGridView gridIstatistikTeminler;
        private System.Windows.Forms.DataGridViewTextBoxColumn SicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAd;
        private System.Windows.Forms.Button btnIstatistikFirmaGetir;
    }
}