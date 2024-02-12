using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeminProject
{
    public partial class frmTeminDetay : Form
    {
        TeminDbEntities db = new TeminDbEntities();

        public frmTeminDetay()
        {
            InitializeComponent();
        }

        private void btnTeminKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeminDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Çıkmak istiyor musunuz?", "Temin Detay Sayfası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void TeminBilgileriDoldur()
        {
            var temin = db.Teminler.Find(Convert.ToInt32(lblTeminId.Text));
            txtDosyaNo.Text = temin.DosyaNo.ToString();
            txtIsinAdi.Text = temin.IsinAdi;
            cmbFirmaAdi.Text = temin.Firmalar.FirmaAd;
            cmbTeminSekli.Text = temin.TeminSekilleri.SekilAd;
            cmbTeminTipi.Text = temin.TeminTipleri.TipAd;
            cmbTeminTuru.Text = temin.TeminTürleri.TurAd;
            txtAciklama.Text = temin.Aciklama;
            txtDosyaYolu.Text = temin.DosyaYolu;
            txtFaturaTutari.Text = temin.FaturaTutar.ToString();
            dateTimePicker1.Text = temin.TeminTarihi.ToString();
            dateTimePicker2.Text = temin.KayitTarihi.ToString();
        }

        private void frmTeminDetay_Load(object sender, EventArgs e)
        {
            TeminBilgileriDoldur();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtDosyaYolu.Text);
            MessageBox.Show("Dosya yolu kopyalandı.","Temin Detay Sayfası",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
