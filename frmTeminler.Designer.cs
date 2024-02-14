
namespace TeminProject
{
    partial class frmTeminler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeminler));
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridTeminler = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsinAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SekilAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeminTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teminTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teminTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teminŞekilleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.rdTeminYili = new System.Windows.Forms.RadioButton();
            this.rdTeminTipi = new System.Windows.Forms.RadioButton();
            this.r5dTeminTuru = new System.Windows.Forms.RadioButton();
            this.rdTeminSekli = new System.Windows.Forms.RadioButton();
            this.rdIsinAdi = new System.Windows.Forms.RadioButton();
            this.rdFirma = new System.Windows.Forms.RadioButton();
            this.txtTeminAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirmaDetay = new System.Windows.Forms.Button();
            this.btnFirmaRaporAl = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.btnfirmaGuncelle = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamKayit = new System.Windows.Forms.TextBox();
            this.txtToplamFatura = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeminler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.güncelleToolStripMenuItem.Text = "Yenile";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // gridTeminler
            // 
            this.gridTeminler.AllowUserToAddRows = false;
            this.gridTeminler.AllowUserToDeleteRows = false;
            this.gridTeminler.BackgroundColor = System.Drawing.Color.White;
            this.gridTeminler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeminler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DosyaNo,
            this.IsinAdi,
            this.FirmaAd,
            this.SekilAd,
            this.TurAd,
            this.TipAd,
            this.TeminTarihi,
            this.FaturaTutar});
            this.gridTeminler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridTeminler.Location = new System.Drawing.Point(1, 25);
            this.gridTeminler.Name = "gridTeminler";
            this.gridTeminler.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridTeminler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTeminler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeminler.Size = new System.Drawing.Size(1010, 464);
            this.gridTeminler.TabIndex = 25;
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
            // DosyaNo
            // 
            this.DosyaNo.DataPropertyName = "DosyaNo";
            this.DosyaNo.HeaderText = "Dosya No";
            this.DosyaNo.MinimumWidth = 50;
            this.DosyaNo.Name = "DosyaNo";
            this.DosyaNo.ReadOnly = true;
            this.DosyaNo.Width = 50;
            // 
            // IsinAdi
            // 
            this.IsinAdi.DataPropertyName = "IsinAdi";
            this.IsinAdi.HeaderText = "İşin Adı";
            this.IsinAdi.MinimumWidth = 155;
            this.IsinAdi.Name = "IsinAdi";
            this.IsinAdi.ReadOnly = true;
            this.IsinAdi.Width = 155;
            // 
            // FirmaAd
            // 
            this.FirmaAd.DataPropertyName = "FirmaAd";
            this.FirmaAd.HeaderText = "İşi Yapan Firma";
            this.FirmaAd.MinimumWidth = 155;
            this.FirmaAd.Name = "FirmaAd";
            this.FirmaAd.ReadOnly = true;
            this.FirmaAd.Width = 155;
            // 
            // SekilAd
            // 
            this.SekilAd.DataPropertyName = "SekilAd";
            this.SekilAd.HeaderText = "Temin Şekli";
            this.SekilAd.MinimumWidth = 140;
            this.SekilAd.Name = "SekilAd";
            this.SekilAd.ReadOnly = true;
            this.SekilAd.Width = 140;
            // 
            // TurAd
            // 
            this.TurAd.DataPropertyName = "TurAd";
            this.TurAd.HeaderText = "Temin Türü";
            this.TurAd.MinimumWidth = 125;
            this.TurAd.Name = "TurAd";
            this.TurAd.ReadOnly = true;
            this.TurAd.Width = 125;
            // 
            // TipAd
            // 
            this.TipAd.DataPropertyName = "TipAd";
            this.TipAd.HeaderText = "Temin Tipi";
            this.TipAd.MinimumWidth = 125;
            this.TipAd.Name = "TipAd";
            this.TipAd.ReadOnly = true;
            this.TipAd.Width = 125;
            // 
            // TeminTarihi
            // 
            this.TeminTarihi.DataPropertyName = "TeminTarihi";
            this.TeminTarihi.HeaderText = "Temin Tarihi";
            this.TeminTarihi.MinimumWidth = 110;
            this.TeminTarihi.Name = "TeminTarihi";
            this.TeminTarihi.ReadOnly = true;
            this.TeminTarihi.Width = 110;
            // 
            // FaturaTutar
            // 
            this.FaturaTutar.DataPropertyName = "FaturaTutar";
            this.FaturaTutar.HeaderText = "Fatura Tutar";
            this.FaturaTutar.MinimumWidth = 110;
            this.FaturaTutar.Name = "FaturaTutar";
            this.FaturaTutar.ReadOnly = true;
            this.FaturaTutar.Width = 110;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.istatistiklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teminTipiToolStripMenuItem,
            this.teminTürleriToolStripMenuItem,
            this.teminŞekilleriToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.firmaTürleriToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // teminTipiToolStripMenuItem
            // 
            this.teminTipiToolStripMenuItem.Name = "teminTipiToolStripMenuItem";
            this.teminTipiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.teminTipiToolStripMenuItem.Text = "Temin Tipleri";
            this.teminTipiToolStripMenuItem.Click += new System.EventHandler(this.teminTipiToolStripMenuItem_Click);
            // 
            // teminTürleriToolStripMenuItem
            // 
            this.teminTürleriToolStripMenuItem.Name = "teminTürleriToolStripMenuItem";
            this.teminTürleriToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.teminTürleriToolStripMenuItem.Text = "Temin Türleri";
            this.teminTürleriToolStripMenuItem.Click += new System.EventHandler(this.teminTürleriToolStripMenuItem_Click);
            // 
            // teminŞekilleriToolStripMenuItem
            // 
            this.teminŞekilleriToolStripMenuItem.Name = "teminŞekilleriToolStripMenuItem";
            this.teminŞekilleriToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.teminŞekilleriToolStripMenuItem.Text = "Temin Şekilleri";
            this.teminŞekilleriToolStripMenuItem.Click += new System.EventHandler(this.teminŞekilleriToolStripMenuItem_Click);
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.firmalarToolStripMenuItem.Text = "Firmalar";
            this.firmalarToolStripMenuItem.Click += new System.EventHandler(this.firmalarToolStripMenuItem_Click);
            // 
            // firmaTürleriToolStripMenuItem
            // 
            this.firmaTürleriToolStripMenuItem.Name = "firmaTürleriToolStripMenuItem";
            this.firmaTürleriToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.firmaTürleriToolStripMenuItem.Text = "Firma Türleri";
            this.firmaTürleriToolStripMenuItem.Click += new System.EventHandler(this.firmaTürleriToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istatistikleriGösterToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // istatistikleriGösterToolStripMenuItem
            // 
            this.istatistikleriGösterToolStripMenuItem.Name = "istatistikleriGösterToolStripMenuItem";
            this.istatistikleriGösterToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.istatistikleriGösterToolStripMenuItem.Click += new System.EventHandler(this.istatistikleriGösterToolStripMenuItem_Click);
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.rdTeminYili);
            this.grpArama.Controls.Add(this.rdTeminTipi);
            this.grpArama.Controls.Add(this.r5dTeminTuru);
            this.grpArama.Controls.Add(this.rdTeminSekli);
            this.grpArama.Controls.Add(this.rdIsinAdi);
            this.grpArama.Controls.Add(this.rdFirma);
            this.grpArama.Controls.Add(this.txtTeminAra);
            this.grpArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpArama.ForeColor = System.Drawing.Color.White;
            this.grpArama.Location = new System.Drawing.Point(1012, 170);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(133, 193);
            this.grpArama.TabIndex = 34;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama Seçenekleri";
            // 
            // rdTeminYili
            // 
            this.rdTeminYili.AutoSize = true;
            this.rdTeminYili.Location = new System.Drawing.Point(7, 169);
            this.rdTeminYili.Name = "rdTeminYili";
            this.rdTeminYili.Size = new System.Drawing.Size(80, 17);
            this.rdTeminYili.TabIndex = 6;
            this.rdTeminYili.TabStop = true;
            this.rdTeminYili.Text = "Temin Yılı";
            this.rdTeminYili.UseVisualStyleBackColor = true;
            // 
            // rdTeminTipi
            // 
            this.rdTeminTipi.AutoSize = true;
            this.rdTeminTipi.Location = new System.Drawing.Point(7, 146);
            this.rdTeminTipi.Name = "rdTeminTipi";
            this.rdTeminTipi.Size = new System.Drawing.Size(84, 17);
            this.rdTeminTipi.TabIndex = 5;
            this.rdTeminTipi.TabStop = true;
            this.rdTeminTipi.Text = "Temin Tipi";
            this.rdTeminTipi.UseVisualStyleBackColor = true;
            // 
            // r5dTeminTuru
            // 
            this.r5dTeminTuru.AutoSize = true;
            this.r5dTeminTuru.Location = new System.Drawing.Point(7, 122);
            this.r5dTeminTuru.Name = "r5dTeminTuru";
            this.r5dTeminTuru.Size = new System.Drawing.Size(89, 17);
            this.r5dTeminTuru.TabIndex = 4;
            this.r5dTeminTuru.TabStop = true;
            this.r5dTeminTuru.Text = "Temin Türü";
            this.r5dTeminTuru.UseVisualStyleBackColor = true;
            // 
            // rdTeminSekli
            // 
            this.rdTeminSekli.AutoSize = true;
            this.rdTeminSekli.Location = new System.Drawing.Point(7, 98);
            this.rdTeminSekli.Name = "rdTeminSekli";
            this.rdTeminSekli.Size = new System.Drawing.Size(91, 17);
            this.rdTeminSekli.TabIndex = 3;
            this.rdTeminSekli.TabStop = true;
            this.rdTeminSekli.Text = "Temin Şekli";
            this.rdTeminSekli.UseVisualStyleBackColor = true;
            // 
            // rdIsinAdi
            // 
            this.rdIsinAdi.AutoSize = true;
            this.rdIsinAdi.Location = new System.Drawing.Point(6, 74);
            this.rdIsinAdi.Name = "rdIsinAdi";
            this.rdIsinAdi.Size = new System.Drawing.Size(60, 17);
            this.rdIsinAdi.TabIndex = 2;
            this.rdIsinAdi.TabStop = true;
            this.rdIsinAdi.Text = "İşi Adı";
            this.rdIsinAdi.UseVisualStyleBackColor = true;
            // 
            // rdFirma
            // 
            this.rdFirma.AutoSize = true;
            this.rdFirma.Location = new System.Drawing.Point(6, 51);
            this.rdFirma.Name = "rdFirma";
            this.rdFirma.Size = new System.Drawing.Size(112, 17);
            this.rdFirma.TabIndex = 1;
            this.rdFirma.TabStop = true;
            this.rdFirma.Text = "İşi Yapan Firma";
            this.rdFirma.UseVisualStyleBackColor = true;
            // 
            // txtTeminAra
            // 
            this.txtTeminAra.Location = new System.Drawing.Point(6, 19);
            this.txtTeminAra.Name = "txtTeminAra";
            this.txtTeminAra.Size = new System.Drawing.Size(117, 20);
            this.txtTeminAra.TabIndex = 0;
            this.txtTeminAra.TextChanged += new System.EventHandler(this.txtTeminAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Toplam Kayıt Sayısı";
            // 
            // btnFirmaDetay
            // 
            this.btnFirmaDetay.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaDetay.ForeColor = System.Drawing.Color.White;
            this.btnFirmaDetay.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaDetay.Image")));
            this.btnFirmaDetay.Location = new System.Drawing.Point(1017, 132);
            this.btnFirmaDetay.Name = "btnFirmaDetay";
            this.btnFirmaDetay.Size = new System.Drawing.Size(121, 32);
            this.btnFirmaDetay.TabIndex = 32;
            this.btnFirmaDetay.Text = "Detay";
            this.btnFirmaDetay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaDetay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaDetay.UseVisualStyleBackColor = false;
            this.btnFirmaDetay.Click += new System.EventHandler(this.btnFirmaDetay_Click);
            // 
            // btnFirmaRaporAl
            // 
            this.btnFirmaRaporAl.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaRaporAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnFirmaRaporAl.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaRaporAl.Image")));
            this.btnFirmaRaporAl.Location = new System.Drawing.Point(1012, 449);
            this.btnFirmaRaporAl.Name = "btnFirmaRaporAl";
            this.btnFirmaRaporAl.Size = new System.Drawing.Size(132, 38);
            this.btnFirmaRaporAl.TabIndex = 29;
            this.btnFirmaRaporAl.Text = "Rapor Al";
            this.btnFirmaRaporAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaRaporAl.UseVisualStyleBackColor = false;
            this.btnFirmaRaporAl.Click += new System.EventHandler(this.btnFirmaRaporAl_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Teal;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(1017, 97);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 32);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.ForeColor = System.Drawing.Color.White;
            this.btnFirmaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.Image")));
            this.btnFirmaEkle.Location = new System.Drawing.Point(1017, 27);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(121, 32);
            this.btnFirmaEkle.TabIndex = 26;
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // btnfirmaGuncelle
            // 
            this.btnfirmaGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnfirmaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfirmaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirmaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfirmaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnfirmaGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnfirmaGuncelle.Image")));
            this.btnfirmaGuncelle.Location = new System.Drawing.Point(1017, 62);
            this.btnfirmaGuncelle.Name = "btnfirmaGuncelle";
            this.btnfirmaGuncelle.Size = new System.Drawing.Size(121, 32);
            this.btnfirmaGuncelle.TabIndex = 27;
            this.btnfirmaGuncelle.Text = "Güncelle";
            this.btnfirmaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfirmaGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfirmaGuncelle.UseVisualStyleBackColor = false;
            this.btnfirmaGuncelle.Click += new System.EventHandler(this.btnfirmaGuncelle_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1015, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Toplam Fatura Tutarı";
            // 
            // txtToplamKayit
            // 
            this.txtToplamKayit.Enabled = false;
            this.txtToplamKayit.Location = new System.Drawing.Point(1019, 385);
            this.txtToplamKayit.Name = "txtToplamKayit";
            this.txtToplamKayit.Size = new System.Drawing.Size(59, 20);
            this.txtToplamKayit.TabIndex = 38;
            // 
            // txtToplamFatura
            // 
            this.txtToplamFatura.Enabled = false;
            this.txtToplamFatura.Location = new System.Drawing.Point(1019, 424);
            this.txtToplamFatura.Name = "txtToplamFatura";
            this.txtToplamFatura.Size = new System.Drawing.Size(116, 20);
            this.txtToplamFatura.TabIndex = 39;
            // 
            // frmTeminler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1146, 490);
            this.Controls.Add(this.txtToplamFatura);
            this.Controls.Add(this.txtToplamKayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.btnFirmaDetay);
            this.Controls.Add(this.btnFirmaRaporAl);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnFirmaEkle);
            this.Controls.Add(this.btnfirmaGuncelle);
            this.Controls.Add(this.gridTeminler);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTeminler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teminler Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeminler_FormClosing);
            this.Load += new System.EventHandler(this.frmTeminler_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeminler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmaDetay;
        private System.Windows.Forms.Button btnFirmaRaporAl;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Button btnfirmaGuncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.DataGridView gridTeminler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teminTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teminTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teminŞekilleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.RadioButton rdTeminTipi;
        private System.Windows.Forms.RadioButton r5dTeminTuru;
        private System.Windows.Forms.RadioButton rdTeminSekli;
        private System.Windows.Forms.RadioButton rdIsinAdi;
        private System.Windows.Forms.RadioButton rdFirma;
        private System.Windows.Forms.TextBox txtTeminAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsinAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SekilAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeminTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaTutar;
        private System.Windows.Forms.ToolStripMenuItem istatistikleriGösterToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RadioButton rdTeminYili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamKayit;
        private System.Windows.Forms.TextBox txtToplamFatura;
    }
}