
namespace TeminProject
{
    partial class frmTeminSekli
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
            this.listTeminSekilleri = new System.Windows.Forms.ListBox();
            this.btnTeminSekliSil = new System.Windows.Forms.Button();
            this.btnTeminSekliKaydet = new System.Windows.Forms.Button();
            this.txtTeminSekli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeminSekliGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTeminSekilleri
            // 
            this.listTeminSekilleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listTeminSekilleri.FormattingEnabled = true;
            this.listTeminSekilleri.Location = new System.Drawing.Point(239, 30);
            this.listTeminSekilleri.Name = "listTeminSekilleri";
            this.listTeminSekilleri.Size = new System.Drawing.Size(193, 147);
            this.listTeminSekilleri.TabIndex = 14;
            this.listTeminSekilleri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listTeminSekilleri_MouseClick);
            // 
            // btnTeminSekliSil
            // 
            this.btnTeminSekliSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminSekliSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminSekliSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminSekliSil.ForeColor = System.Drawing.Color.White;
            this.btnTeminSekliSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminSekliSil.Location = new System.Drawing.Point(16, 116);
            this.btnTeminSekliSil.Name = "btnTeminSekliSil";
            this.btnTeminSekliSil.Size = new System.Drawing.Size(205, 24);
            this.btnTeminSekliSil.TabIndex = 13;
            this.btnTeminSekliSil.Text = "Sil";
            this.btnTeminSekliSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminSekliSil.UseVisualStyleBackColor = true;
            this.btnTeminSekliSil.Click += new System.EventHandler(this.btnTeminSekliSil_Click);
            // 
            // btnTeminSekliKaydet
            // 
            this.btnTeminSekliKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnTeminSekliKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminSekliKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminSekliKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminSekliKaydet.ForeColor = System.Drawing.Color.White;
            this.btnTeminSekliKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminSekliKaydet.Location = new System.Drawing.Point(16, 56);
            this.btnTeminSekliKaydet.Name = "btnTeminSekliKaydet";
            this.btnTeminSekliKaydet.Size = new System.Drawing.Size(205, 24);
            this.btnTeminSekliKaydet.TabIndex = 12;
            this.btnTeminSekliKaydet.Text = "Ekle";
            this.btnTeminSekliKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminSekliKaydet.UseVisualStyleBackColor = false;
            this.btnTeminSekliKaydet.Click += new System.EventHandler(this.btnTeminSekliKaydet_Click);
            // 
            // txtTeminSekli
            // 
            this.txtTeminSekli.Location = new System.Drawing.Point(16, 30);
            this.txtTeminSekli.Name = "txtTeminSekli";
            this.txtTeminSekli.Size = new System.Drawing.Size(205, 20);
            this.txtTeminSekli.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temin Şekli";
            // 
            // btnTeminSekliGuncelle
            // 
            this.btnTeminSekliGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnTeminSekliGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeminSekliGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeminSekliGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeminSekliGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnTeminSekliGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeminSekliGuncelle.Location = new System.Drawing.Point(16, 86);
            this.btnTeminSekliGuncelle.Name = "btnTeminSekliGuncelle";
            this.btnTeminSekliGuncelle.Size = new System.Drawing.Size(205, 24);
            this.btnTeminSekliGuncelle.TabIndex = 15;
            this.btnTeminSekliGuncelle.Text = "Güncelle";
            this.btnTeminSekliGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeminSekliGuncelle.UseVisualStyleBackColor = false;
            this.btnTeminSekliGuncelle.Click += new System.EventHandler(this.btnTeminSekliGuncelle_Click);
            // 
            // frmTeminSekli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.btnTeminSekliGuncelle);
            this.Controls.Add(this.listTeminSekilleri);
            this.Controls.Add(this.btnTeminSekliSil);
            this.Controls.Add(this.btnTeminSekliKaydet);
            this.Controls.Add(this.txtTeminSekli);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTeminSekli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temin Şekli Sayfası";
            this.Load += new System.EventHandler(this.frmTeminSekli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTeminSekilleri;
        private System.Windows.Forms.Button btnTeminSekliSil;
        private System.Windows.Forms.Button btnTeminSekliKaydet;
        private System.Windows.Forms.TextBox txtTeminSekli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeminSekliGuncelle;
    }
}