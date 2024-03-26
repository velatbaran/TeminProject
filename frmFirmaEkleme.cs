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
    public partial class frmFirmaEkle : Form
    {
        TeminDbEntities db = new TeminDbEntities();
        Firmalar firmalar = new Firmalar();
        public frmFirmaEkle()
        {
            InitializeComponent();
        }

        private void btnFirmaVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            TümFirmalariGetir();
        }

        private void frmFirmaEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Çıkmak istiyor musunuz?", "Firma Ekleme Sayfası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirmaAd.Text) == true || string.IsNullOrEmpty(txtFirmaYetkiliKisi.Text) == true || cmbFirmaTürü.Text == "seçiniz..." || string.IsNullOrEmpty(txtFirmaTelefon.Text) == true || string.IsNullOrEmpty(txtFirmaSicilNo.Text) == true || string.IsNullOrEmpty(txtFirmaVergiDairesi.Text) == true || string.IsNullOrEmpty(txtFirmaVergiNo.Text) == true || string.IsNullOrEmpty(txtFirmaHesapNo.Text) == true || string.IsNullOrEmpty(txtFirmaEmail.Text) == true)
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz!","Firma Ekleme Sayfası",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if(db.Firmalar.Any(x=>x.SicilNo == txtFirmaSicilNo.Text || x.TcNo == txtFirmaTCKimlikNo.Text))
                {
                    if(db.Firmalar.Any(x => x.SicilNo == txtFirmaSicilNo.Text))
                        MessageBox.Show("Aynı Sicil No' ya sahip kayıt zaten var.", "Firma Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (db.Firmalar.Any(x => x.TcNo == txtFirmaTCKimlikNo.Text))
                        MessageBox.Show("Aynı TC No' ya sahip kayıt zaten var.", "Firma Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    firmalar = new Firmalar()
                    {
                        FirmaAd = txtFirmaAd.Text,
                        YetkiliKisi = txtFirmaYetkiliKisi.Text,
                        FirmaTuru = Convert.ToInt32(cmbFirmaTürü.SelectedValue),
                        Telefon = txtFirmaTelefon.Text,
                        Adres = txtFirmaAdres.Text,
                        Email = txtFirmaEmail.Text,
                        WebAdresi = txtFirmaWebAdresi.Text,
                        SicilNo = txtFirmaSicilNo.Text,
                        VergiDairesi = txtFirmaVergiDairesi.Text,
                        VergiNo = txtFirmaVergiNo.Text,
                        TcNo = txtFirmaTCKimlikNo.Text,
                        BankaAdi = txtFirmaBankaAdi.Text,
                        SubeAdi = txtSubeAdi.Text,
                        HesapOrIbanNo = txtFirmaHesapNo.Text
                    };
                    db.Firmalar.Add(firmalar);
                    db.SaveChanges();
                    Temizle();
                    TümFirmalariGetir();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti", "Firma Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
        }

        private void frmFirmaEkle_Load(object sender, EventArgs e)
        {
            FirmaTürleriDoldur();
        }

        private void FirmaTürleriDoldur()
        {
            cmbFirmaTürü.DisplayMember = "FirmaTurAd";
            cmbFirmaTürü.ValueMember = "Id";
            cmbFirmaTürü.DataSource = db.FirmaTurleri.ToList();
        }

        private void TümFirmalariGetir()
        {
            frmFirmalar f = (frmFirmalar)Application.OpenForms["frmFirmalar"];
            if (f != null)
            {
                f.TümFirmalar();
            }
        }
    }
}
