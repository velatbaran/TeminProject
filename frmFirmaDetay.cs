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
    public partial class frmFirmaDetay : Form
    {
        TeminDbEntities db = new TeminDbEntities();

        public frmFirmaDetay()
        {
            InitializeComponent();
        }

        private void frmFirmaDetay_Load(object sender, EventArgs e)
        {
            FirmaBilgileriDoldur();
        }
        private void FirmaBilgileriDoldur()
        {
            var firma = db.Firmalar.Find(Convert.ToInt32(lblFirmaId.Text));
            txtFirmaAd.Text = firma.FirmaAd;
            txtFirmaYetkiliKisi.Text = firma.YetkiliKisi;
            cmbFirmaTürü.Text = firma.FirmaTurleri.FirmaTurAd;
            txtFirmaTelefon.Text = firma.Telefon;
            txtFirmaAdres.Text = firma.Adres;
            txtFirmaEmail.Text = firma.Email;
            txtFirmaWebAdresi.Text = firma.WebAdresi;
            txtFirmaSicilNo.Text = firma.SicilNo;
            txtFirmaVergiDairesi.Text = firma.VergiDairesi;
            txtFirmaVergiNo.Text = firma.VergiNo;
            txtFirmaTCKimlikNo.Text = firma.TcNo;
            txtFirmaBankaAdi.Text = firma.BankaAdi;
            txtSubeAdi.Text = firma.SubeAdi;
            txtFirmaHesapNo.Text = firma.HesapOrIbanNo;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFirmaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Çıkmak istiyor musunuz?", "Firma Ekleme Sayfası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtFirmaHesapNo.Text);
            MessageBox.Show("Hesap/Iban no kopyalandı.", "Firma Detay Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
