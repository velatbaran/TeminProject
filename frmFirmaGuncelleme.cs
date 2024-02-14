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
    public partial class frmFirmaGuncelle : Form
    {
        TeminDbEntities db = new TeminDbEntities();

        public frmFirmaGuncelle()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtFirmaAd.Focus();
            txtFirmaAd.Clear();
            txtFirmaYetkiliKisi.Clear();
            cmbFirmaTürü.Text = "seçiniz...";
            txtFirmaTelefon.Clear();
            txtFirmaAdres.Clear();
            txtFirmaEmail.Clear();
            txtFirmaWebAdresi.Clear();
            txtFirmaSicilNo.Clear();
            txtFirmaVergiDairesi.Clear();
            txtFirmaVergiNo.Clear();
            txtFirmaTCKimlikNo.Clear();
            txtFirmaBankaAdi.Clear();
            txtSubeAdi.Clear();
            txtFirmaHesapNo.Clear();
            lblFirmaId.Text = "";
        }

        private void btnFirmaVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirmaTürleriDoldur()
        {
            cmbFirmaTürü.DisplayMember = "FirmaTurAd";
            cmbFirmaTürü.ValueMember = "Id";
            cmbFirmaTürü.DataSource = db.FirmaTurleri.ToList();
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

        private void frmFirmaGuncelle_Load(object sender, EventArgs e)
        {
            FirmaTürleriDoldur();
            FirmaBilgileriDoldur();
        }
       
        private void frmFirmaGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Çıkmak istiyor musunuz?", "Firma Güncelleme Sayfası", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    TümFirmalariGetir();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(lblFirmaId.Text);
            var firma = db.Firmalar.Find(_id);
            if (firma == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Firma Güncellleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtFirmaAd.Text) == true || string.IsNullOrEmpty(txtFirmaYetkiliKisi.Text) == true || cmbFirmaTürü.Text == "seçiniz..." || string.IsNullOrEmpty(txtFirmaTelefon.Text) == true || string.IsNullOrEmpty(txtFirmaSicilNo.Text) == true || string.IsNullOrEmpty(txtFirmaVergiDairesi.Text) == true || string.IsNullOrEmpty(txtFirmaVergiNo.Text) == true || string.IsNullOrEmpty(txtFirmaHesapNo.Text) == true || string.IsNullOrEmpty(txtFirmaEmail.Text) == true)
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz!", "Firma Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (db.Firmalar.Any(x => x.Id != _id && (x.SicilNo == txtFirmaSicilNo.Text || x.TcNo == txtFirmaTCKimlikNo.Text)))
                    {
                        if (db.Firmalar.Any(x => x.Id != _id && x.SicilNo == txtFirmaSicilNo.Text))
                            MessageBox.Show("Aynı Sicil No' ya sahip kayıt zaten var.", "Firma Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (db.Firmalar.Any(x => x.Id != _id && x.TcNo == txtFirmaTCKimlikNo.Text))
                            MessageBox.Show("Aynı TC No' ya sahip kayıt zaten var.", "Firma Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        firma.FirmaAd = txtFirmaAd.Text;
                        firma.YetkiliKisi = txtFirmaYetkiliKisi.Text;
                        firma.FirmaTuru = Convert.ToInt32(cmbFirmaTürü.SelectedValue);
                        firma.Telefon = txtFirmaTelefon.Text;
                        firma.Adres = txtFirmaAdres.Text;
                        firma.Email = txtFirmaEmail.Text;
                        firma.WebAdresi = txtFirmaWebAdresi.Text;
                        firma.SicilNo = txtFirmaSicilNo.Text;
                        firma.VergiDairesi = txtFirmaVergiDairesi.Text;
                        firma.VergiNo = txtFirmaVergiNo.Text;
                        firma.TcNo = txtFirmaTCKimlikNo.Text;
                        firma.BankaAdi = txtFirmaBankaAdi.Text;
                        firma.SubeAdi = txtSubeAdi.Text;
                        firma.HesapOrIbanNo = txtFirmaHesapNo.Text;
                        db.SaveChanges();
                        Temizle();
                        TümFirmalariGetir();
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Firma Güncellleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }       
        }

        private void TümFirmalariGetir()
        {
            frmFirmalar f = (frmFirmalar)Application.OpenForms["frmFirmalar"];
            if (f != null)
            {
                f.gridFirmalar.DataSource = (from k in db.Firmalar.Include("FirmaTurleri").ToList()
                                           select new { k.Id, k.FirmaAd, k.YetkiliKisi, k.FirmaTurleri.FirmaTurAd, k.SicilNo, k.VergiDairesi, k.VergiNo, k.Telefon, k.Email }).ToList();
            }
        }
    }
}
