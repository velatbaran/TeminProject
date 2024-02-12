
namespace TeminProject
{
    partial class frmTeminTipi
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
            this.listTeminTipleri = new System.Windows.Forms.ListBox();
            this.btnTeminTipiSil = new System.Windows.Forms.Button();
            this.btnTeminTipiKaydet = new System.Windows.Forms.Button();
            this.txtTeminTipi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeminTipGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTeminTipleri
            // 
            this.listTeminTipleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listTeminTipleri.FormattingEnabled = true;
            this.listTeminTipleri.Location = new System.Drawing.Point(238, 32);
            this.listTeminTipleri.Name = "listTeminTipleri";
            this.listTeminTipleri.Size = new System.Drawing.Size(193, 147);
            this.listTeminTipleri.TabIndex = 9;
            this.listTeminTipleri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listTeminTipleri_MouseClick);
            // 
            // btnTeminTipiSil
            // 
            this.btnTeminTipiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminTipiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminTipiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminTipiSil.ForeColor = System.Drawing.Color.White;
            this.btnTeminTipiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminTipiSil.Location = new System.Drawing.Point(15, 118);
            this.btnTeminTipiSil.Name = "btnTeminTipiSil";
            this.btnTeminTipiSil.Size = new System.Drawing.Size(205, 24);
            this.btnTeminTipiSil.TabIndex = 8;
            this.btnTeminTipiSil.Text = "Sil";
            this.btnTeminTipiSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminTipiSil.UseVisualStyleBackColor = true;
            this.btnTeminTipiSil.Click += new System.EventHandler(this.btnTeminTipiSil_Click);
            // 
            // btnTeminTipiKaydet
            // 
            this.btnTeminTipiKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnTeminTipiKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminTipiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminTipiKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminTipiKaydet.ForeColor = System.Drawing.Color.White;
            this.btnTeminTipiKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminTipiKaydet.Location = new System.Drawing.Point(15, 58);
            this.btnTeminTipiKaydet.Name = "btnTeminTipiKaydet";
            this.btnTeminTipiKaydet.Size = new System.Drawing.Size(205, 24);
            this.btnTeminTipiKaydet.TabIndex = 7;
            this.btnTeminTipiKaydet.Text = "Ekle";
            this.btnTeminTipiKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminTipiKaydet.UseVisualStyleBackColor = false;
            this.btnTeminTipiKaydet.Click += new System.EventHandler(this.btnTeminTipiKaydet_Click);
            // 
            // txtTeminTipi
            // 
            this.txtTeminTipi.Location = new System.Drawing.Point(15, 32);
            this.txtTeminTipi.Name = "txtTeminTipi";
            this.txtTeminTipi.Size = new System.Drawing.Size(205, 20);
            this.txtTeminTipi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temin Tipi";
            // 
            // btnTeminTipGuncelle
            // 
            this.btnTeminTipGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnTeminTipGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminTipGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminTipGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminTipGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnTeminTipGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminTipGuncelle.Location = new System.Drawing.Point(15, 88);
            this.btnTeminTipGuncelle.Name = "btnTeminTipGuncelle";
            this.btnTeminTipGuncelle.Size = new System.Drawing.Size(205, 24);
            this.btnTeminTipGuncelle.TabIndex = 10;
            this.btnTeminTipGuncelle.Text = "Güncelle";
            this.btnTeminTipGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminTipGuncelle.UseVisualStyleBackColor = false;
            this.btnTeminTipGuncelle.Click += new System.EventHandler(this.btnTeminTipGuncelle_Click);
            // 
            // frmTeminTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.btnTeminTipGuncelle);
            this.Controls.Add(this.listTeminTipleri);
            this.Controls.Add(this.btnTeminTipiSil);
            this.Controls.Add(this.btnTeminTipiKaydet);
            this.Controls.Add(this.txtTeminTipi);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTeminTipi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temin Tipi Sayfası";
            this.Load += new System.EventHandler(this.frmTeminTipi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTeminTipleri;
        private System.Windows.Forms.Button btnTeminTipiSil;
        private System.Windows.Forms.Button btnTeminTipiKaydet;
        private System.Windows.Forms.TextBox txtTeminTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeminTipGuncelle;
    }
}