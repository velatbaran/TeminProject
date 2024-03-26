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
    public partial class frmTeminEkle : Form
    {
        TeminDbEntities db = new TeminDbEntities();
        Teminler teminler = new Teminler();

        public frmTeminEkle()
        {
            InitializeComponent();
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text) == true || string.IsNullOrEmpty(txtDosyaYolu.Text) == true || cmbTeminTuru.Text == "seçiniz..." || string.IsNullOrEmpty(txtIsinAdi.Text) == true || cmbTeminTipi.Text == "seçiniz..." || cmbTeminSekli.Text == "seçiniz..." || cmbFirmaAdi.Text == "seçiniz..." || string.IsNullOrEmpty(txtFaturaTutari.Text) == true)
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz!", "Temin Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //int dosyaNo = Convert.ToInt32(txtDosyaNo.Text);
                if (db.Teminler.Any(x => x.DosyaNo == txtDosyaNo.Text))
                {
                    MessageBox.Show("Aynı Dosya No' ya sahip kayıt zaten var.", "Temin Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    teminler = new Teminler()
                    {
                        DosyaNo = txtDosyaNo.Text,
                        IsinAdi = txtIsinAdi.Text,
                        IsiYapanFirma = Convert.ToInt32(cmbFirmaAdi.SelectedValue),
                        TeminSekli = Convert.ToInt32(cmbTeminSekli.SelectedValue),
                        TeminTipi = Convert.ToInt32(cmbTeminTipi.SelectedValue),
                        TeminTuru = Convert.ToInt32(cmbTeminTuru.SelectedValue),
                        Aciklama = txtAciklama.Text,
                        DosyaYolu = txtDosyaYolu.Text,
                        TeminTarihi = dateTimePicker1.Value,
                        FaturaTutar = Convert.ToDecimal(txtFaturaTutari.Text),
                        KayitTarihi = DateTime.Now
                };
                    db.Teminler.Add(teminler);
                    db.SaveChanges();
                    Temizle();
                    TümTeminleriGetir();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti", "Temin Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFirmaVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
            TümTeminleriGetir();
        }

        public void Temizle()
        {
            txtDosyaNo.Focus();
            txtDosyaNo.Clear();
            cmbFirmaAdi.Text = "seçiniz...";
            cmbTeminSekli.Text = "seçiniz...";
            cmbTeminTipi.Text = "seçiniz...";
            cmbTeminTuru.Text = "seçiniz...";
            txtAciklama.Clear();
            txtDosyaYolu.Clear();
            txtIsinAdi.Clear();
            txtFaturaTutari.Clear();
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void FirmalariDoldur()
        {
            cmbFirmaAdi.DisplayMember = "FirmaAd";
            cmbFirmaAdi.ValueMember = "Id";
            cmbFirmaAdi.DataSource = db.Firmalar.ToList();
        }

        private void TeminSekilleriDoldur()
        {
            cmbTeminSekli.DisplayMember = "SekilAd";
            cmbTeminSekli.ValueMember = "Id";
            cmbTeminSekli.DataSource = db.TeminSekilleri.ToList();
        }

        private void TeminTipleriDoldur()
        {
            cmbTeminTipi.DisplayMember = "TipAd";
            cmbTeminTipi.ValueMember = "Id";
            cmbTeminTipi.DataSource = db.TeminTipleri.ToList();
        }

        private void TeminTurleriDoldur()
        {
            cmbTeminTuru.DisplayMember = "TurAd";
            cmbTeminTuru.ValueMember = "Id";
            cmbTeminTuru.DataSource = db.TeminTürleri.ToList();
        }

        private void frmTeminEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Çıkmak istiyor musunuz?", "Temin Ekleme Sayfası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    TümTeminleriGetir();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmTeminEkle_Load(object sender, EventArgs e)
        {
            TeminTurleriDoldur();
            TeminTipleriDoldur();
            TeminSekilleriDoldur();
            FirmalariDoldur();
        }

        private void TümTeminleriGetir()
        {
            frmTeminler f = (frmTeminler)Application.OpenForms["frmTeminler"];
            if (f != null)
            {
                f.TümTeminler();
            }
        }
    }
}
