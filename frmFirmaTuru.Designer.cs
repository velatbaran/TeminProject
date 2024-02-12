
namespace TeminProject
{
    partial class frmFirmaTuru
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
            this.btnFirmaTuruGuncelle = new System.Windows.Forms.Button();
            this.listFirmaTurleri = new System.Windows.Forms.ListBox();
            this.btnFirmaTuruSil = new System.Windows.Forms.Button();
            this.btnFirmaTuruKaydet = new System.Windows.Forms.Button();
            this.txtFirmaTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFirmaTuruGuncelle
            // 
            this.btnFirmaTuruGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaTuruGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaTuruGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaTuruGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaTuruGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnFirmaTuruGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaTuruGuncelle.Location = new System.Drawing.Point(16, 86);
            this.btnFirmaTuruGuncelle.Name = "btnFirmaTuruGuncelle";
            this.btnFirmaTuruGuncelle.Size = new System.Drawing.Size(205, 24);
            this.btnFirmaTuruGuncelle.TabIndex = 21;
            this.btnFirmaTuruGuncelle.Text = "Güncelle";
            this.btnFirmaTuruGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaTuruGuncelle.UseVisualStyleBackColor = false;
            this.btnFirmaTuruGuncelle.Click += new System.EventHandler(this.btnFirmaTuruGuncelle_Click);
            // 
            // listFirmaTurleri
            // 
            this.listFirmaTurleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listFirmaTurleri.FormattingEnabled = true;
            this.listFirmaTurleri.Location = new System.Drawing.Point(239, 30);
            this.listFirmaTurleri.Name = "listFirmaTurleri";
            this.listFirmaTurleri.Size = new System.Drawing.Size(193, 147);
            this.listFirmaTurleri.TabIndex = 20;
            this.listFirmaTurleri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFirmaTurleri_MouseClick);
            // 
            // btnFirmaTuruSil
            // 
            this.btnFirmaTuruSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaTuruSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaTuruSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaTuruSil.ForeColor = System.Drawing.Color.White;
            this.btnFirmaTuruSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaTuruSil.Location = new System.Drawing.Point(16, 116);
            this.btnFirmaTuruSil.Name = "btnFirmaTuruSil";
            this.btnFirmaTuruSil.Size = new System.Drawing.Size(205, 24);
            this.btnFirmaTuruSil.TabIndex = 19;
            this.btnFirmaTuruSil.Text = "Sil";
            this.btnFirmaTuruSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaTuruSil.UseVisualStyleBackColor = true;
            this.btnFirmaTuruSil.Click += new System.EventHandler(this.btnFirmaTuruSil_Click);
            // 
            // btnFirmaTuruKaydet
            // 
            this.btnFirmaTuruKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnFirmaTuruKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaTuruKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaTuruKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaTuruKaydet.ForeColor = System.Drawing.Color.White;
            this.btnFirmaTuruKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaTuruKaydet.Location = new System.Drawing.Point(16, 56);
            this.btnFirmaTuruKaydet.Name = "btnFirmaTuruKaydet";
            this.btnFirmaTuruKaydet.Size = new System.Drawing.Size(205, 24);
            this.btnFirmaTuruKaydet.TabIndex = 18;
            this.btnFirmaTuruKaydet.Text = "Ekle";
            this.btnFirmaTuruKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaTuruKaydet.UseVisualStyleBackColor = false;
            this.btnFirmaTuruKaydet.Click += new System.EventHandler(this.btnFirmaTuruKaydet_Click);
            // 
            // txtFirmaTuru
            // 
            this.txtFirmaTuru.Location = new System.Drawing.Point(16, 30);
            this.txtFirmaTuru.Name = "txtFirmaTuru";
            this.txtFirmaTuru.Size = new System.Drawing.Size(205, 20);
            this.txtFirmaTuru.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Firma Türü";
            // 
            // frmFirmaTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.btnFirmaTuruGuncelle);
            this.Controls.Add(this.listFirmaTurleri);
            this.Controls.Add(this.btnFirmaTuruSil);
            this.Controls.Add(this.btnFirmaTuruKaydet);
            this.Controls.Add(this.txtFirmaTuru);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFirmaTuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Türü Sayfası";
            this.Load += new System.EventHandler(this.frmFirmaTuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmaTuruGuncelle;
        private System.Windows.Forms.ListBox listFirmaTurleri;
        private System.Windows.Forms.Button btnFirmaTuruSil;
        private System.Windows.Forms.Button btnFirmaTuruKaydet;
        private System.Windows.Forms.TextBox txtFirmaTuru;
        private System.Windows.Forms.Label label1;
    }
}