
namespace TeminProject
{
    partial class frmTeminTur
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeminTuru = new System.Windows.Forms.TextBox();
            this.btnTeminTürüSil = new System.Windows.Forms.Button();
            this.btnTeminTürüKaydet = new System.Windows.Forms.Button();
            this.listTeminTurleri = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temin Türü";
            // 
            // txtTeminTuru
            // 
            this.txtTeminTuru.Location = new System.Drawing.Point(21, 35);
            this.txtTeminTuru.Name = "txtTeminTuru";
            this.txtTeminTuru.Size = new System.Drawing.Size(205, 20);
            this.txtTeminTuru.TabIndex = 1;
            // 
            // btnTeminTürüSil
            // 
            this.btnTeminTürüSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminTürüSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminTürüSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminTürüSil.ForeColor = System.Drawing.Color.White;
            this.btnTeminTürüSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminTürüSil.Location = new System.Drawing.Point(21, 121);
            this.btnTeminTürüSil.Name = "btnTeminTürüSil";
            this.btnTeminTürüSil.Size = new System.Drawing.Size(205, 24);
            this.btnTeminTürüSil.TabIndex = 3;
            this.btnTeminTürüSil.Text = "Sil";
            this.btnTeminTürüSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminTürüSil.UseVisualStyleBackColor = true;
            this.btnTeminTürüSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnTeminTürüKaydet
            // 
            this.btnTeminTürüKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnTeminTürüKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminTürüKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminTürüKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminTürüKaydet.ForeColor = System.Drawing.Color.White;
            this.btnTeminTürüKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminTürüKaydet.Location = new System.Drawing.Point(21, 61);
            this.btnTeminTürüKaydet.Name = "btnTeminTürüKaydet";
            this.btnTeminTürüKaydet.Size = new System.Drawing.Size(205, 24);
            this.btnTeminTürüKaydet.TabIndex = 2;
            this.btnTeminTürüKaydet.Text = "Ekle";
            this.btnTeminTürüKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminTürüKaydet.UseVisualStyleBackColor = false;
            this.btnTeminTürüKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listTeminTurleri
            // 
            this.listTeminTurleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listTeminTurleri.FormattingEnabled = true;
            this.listTeminTurleri.Location = new System.Drawing.Point(244, 35);
            this.listTeminTurleri.Name = "listTeminTurleri";
            this.listTeminTurleri.Size = new System.Drawing.Size(193, 147);
            this.listTeminTurleri.TabIndex = 4;
            this.listTeminTurleri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listTeminTurleri_MouseClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(21, 91);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(205, 24);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmTeminTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.listTeminTurleri);
            this.Controls.Add(this.btnTeminTürüSil);
            this.Controls.Add(this.btnTeminTürüKaydet);
            this.Controls.Add(this.txtTeminTuru);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTeminTur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temin Türü Sayfası";
            this.Load += new System.EventHandler(this.frmTeminTur_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeminTuru;
        private System.Windows.Forms.Button btnTeminTürüKaydet;
        private System.Windows.Forms.Button btnTeminTürüSil;
        private System.Windows.Forms.ListBox listTeminTurleri;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

