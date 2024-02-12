
namespace TeminProject
{
    partial class frmFirmalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmalar));
            this.gridFirmalar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliKisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaTurAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiDairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtfirmaAra = new System.Windows.Forms.TextBox();
            this.btnFirmaDetay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFirmaRaporAl = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnfirmaGuncelle = new System.Windows.Forms.Button();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirmalar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridFirmalar
            // 
            this.gridFirmalar.AllowUserToAddRows = false;
            this.gridFirmalar.AllowUserToDeleteRows = false;
            this.gridFirmalar.BackgroundColor = System.Drawing.Color.White;
            this.gridFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFirmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirmaAd,
            this.YetkiliKisi,
            this.FirmaTurAd,
            this.SicilNo,
            this.VergiDairesi,
            this.VergiNo,
            this.Telefon,
            this.Email});
            this.gridFirmalar.ContextMenuStrip = this.contextMenuStrip1;
            this.gridFirmalar.Location = new System.Drawing.Point(1, 35);
            this.gridFirmalar.Name = "gridFirmalar";
            this.gridFirmalar.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridFirmalar.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFirmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFirmalar.Size = new System.Drawing.Size(980, 417);
            this.gridFirmalar.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 10;
            // 
            // FirmaAd
            // 
            this.FirmaAd.DataPropertyName = "FirmaAd";
            this.FirmaAd.HeaderText = "Firma Adı";
            this.FirmaAd.MinimumWidth = 150;
            this.FirmaAd.Name = "FirmaAd";
            this.FirmaAd.ReadOnly = true;
            this.FirmaAd.Width = 150;
            // 
            // YetkiliKisi
            // 
            this.YetkiliKisi.DataPropertyName = "YetkiliKisi";
            this.YetkiliKisi.HeaderText = "Yetkili Kişi";
            this.YetkiliKisi.MinimumWidth = 100;
            this.YetkiliKisi.Name = "YetkiliKisi";
            this.YetkiliKisi.ReadOnly = true;
            // 
            // FirmaTurAd
            // 
            this.FirmaTurAd.DataPropertyName = "FirmaTurAd";
            this.FirmaTurAd.HeaderText = "Firma Türü";
            this.FirmaTurAd.MinimumWidth = 100;
            this.FirmaTurAd.Name = "FirmaTurAd";
            this.FirmaTurAd.ReadOnly = true;
            // 
            // SicilNo
            // 
            this.SicilNo.DataPropertyName = "SicilNo";
            this.SicilNo.HeaderText = "Sicil No";
            this.SicilNo.MinimumWidth = 150;
            this.SicilNo.Name = "SicilNo";
            this.SicilNo.ReadOnly = true;
            this.SicilNo.Width = 150;
            // 
            // VergiDairesi
            // 
            this.VergiDairesi.DataPropertyName = "VergiDairesi";
            this.VergiDairesi.HeaderText = "Vergi Dairesi";
            this.VergiDairesi.MinimumWidth = 150;
            this.VergiDairesi.Name = "VergiDairesi";
            this.VergiDairesi.ReadOnly = true;
            this.VergiDairesi.Width = 150;
            // 
            // VergiNo
            // 
            this.VergiNo.DataPropertyName = "VergiNo";
            this.VergiNo.HeaderText = "VergiNo";
            this.VergiNo.MinimumWidth = 100;
            this.VergiNo.Name = "VergiNo";
            this.VergiNo.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 100;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 115;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 115;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.detayToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.detayToolStripMenuItem.Text = "Detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // txtfirmaAra
            // 
            this.txtfirmaAra.Location = new System.Drawing.Point(75, 8);
            this.txtfirmaAra.Name = "txtfirmaAra";
            this.txtfirmaAra.Size = new System.Drawing.Size(429, 20);
            this.txtfirmaAra.TabIndex = 21;
            this.txtfirmaAra.TextChanged += new System.EventHandler(this.txtfirmaAra_TextChanged);
            // 
            // btnFirmaDetay
            // 
            this.btnFirmaDetay.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaDetay.ForeColor = System.Drawing.Color.White;
            this.btnFirmaDetay.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaDetay.Image")));
            this.btnFirmaDetay.Location = new System.Drawing.Point(321, 459);
            this.btnFirmaDetay.Name = "btnFirmaDetay";
            this.btnFirmaDetay.Size = new System.Drawing.Size(100, 32);
            this.btnFirmaDetay.TabIndex = 24;
            this.btnFirmaDetay.Text = "Detay";
            this.btnFirmaDetay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaDetay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaDetay.UseVisualStyleBackColor = false;
            this.btnFirmaDetay.Click += new System.EventHandler(this.btnFirmaDetay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ara";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnFirmaRaporAl
            // 
            this.btnFirmaRaporAl.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaRaporAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnFirmaRaporAl.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaRaporAl.Image")));
            this.btnFirmaRaporAl.Location = new System.Drawing.Point(870, 453);
            this.btnFirmaRaporAl.Name = "btnFirmaRaporAl";
            this.btnFirmaRaporAl.Size = new System.Drawing.Size(100, 48);
            this.btnFirmaRaporAl.TabIndex = 19;
            this.btnFirmaRaporAl.Text = "Rapor Al";
            this.btnFirmaRaporAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaRaporAl.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Teal;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(215, 459);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 32);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnfirmaGuncelle
            // 
            this.btnfirmaGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnfirmaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfirmaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirmaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfirmaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnfirmaGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnfirmaGuncelle.Image")));
            this.btnfirmaGuncelle.Location = new System.Drawing.Point(112, 459);
            this.btnfirmaGuncelle.Name = "btnfirmaGuncelle";
            this.btnfirmaGuncelle.Size = new System.Drawing.Size(97, 32);
            this.btnfirmaGuncelle.TabIndex = 17;
            this.btnfirmaGuncelle.Text = "Güncelle";
            this.btnfirmaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfirmaGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfirmaGuncelle.UseVisualStyleBackColor = false;
            this.btnfirmaGuncelle.Click += new System.EventHandler(this.btnfirmaGuncelle_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.ForeColor = System.Drawing.Color.White;
            this.btnFirmaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.Image")));
            this.btnFirmaEkle.Location = new System.Drawing.Point(6, 459);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(100, 32);
            this.btnFirmaEkle.TabIndex = 16;
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // frmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(982, 504);
            this.Controls.Add(this.btnFirmaDetay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfirmaAra);
            this.Controls.Add(this.btnFirmaRaporAl);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnfirmaGuncelle);
            this.Controls.Add(this.btnFirmaEkle);
            this.Controls.Add(this.gridFirmalar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFirmalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmalar Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFirmalar_FormClosing);
            this.Load += new System.EventHandler(this.frmFirmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFirmalar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.Button btnFirmaRaporAl;
        private System.Windows.Forms.TextBox txtfirmaAra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfirmaGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnFirmaDetay;
        public System.Windows.Forms.DataGridView gridFirmalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliKisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaTurAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiDairesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}