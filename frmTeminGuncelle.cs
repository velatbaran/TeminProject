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
    public partial class frmTeminGuncelle : Form
    {
        TeminDbEntities db = new TeminDbEntities();
        public frmTeminGuncelle()
        {
            InitializeComponent();
        }

        private void btnTeminVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeminGuncelle_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TümTeminleriGetir()
        {
            frmTeminler f = (frmTeminler)Application.OpenForms["frmTeminler"];
            if (f != null)
            {
                f.gridTeminler.DataSource = (from k in db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri").ToList()
                                           select new { k.Id, k.DosyaNo, k.IsinAdi, k.Firmalar.FirmaAd, k.TeminSekilleri.SekilAd, k.TeminTürleri.TurAd, k.TeminTipleri.TipAd,k.TeminTarihi,k.FaturaTutar }).ToList();
            }
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
            lblTeminId.Text = "";
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

        private void frmTeminGuncelle_Load(object sender, EventArgs e)
        {
            TeminTurleriDoldur();
            TeminTipleriDoldur();
            TeminSekilleriDoldur();
            FirmalariDoldur();
            TeminBilgileriDoldur();
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
        }

        private void btnTeminGuncelle_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(lblTeminId.Text);
            var temin = db.Teminler.Find(_id);
            if (temin == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Temin Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtDosyaNo.Text) == true || string.IsNullOrEmpty(txtDosyaYolu.Text) == true || cmbTeminTuru.Text == "seçiniz..." || string.IsNullOrEmpty(txtIsinAdi.Text) == true || cmbTeminTipi.Text == "seçiniz..." || cmbTeminSekli.Text == "seçiniz..." || cmbFirmaAdi.Text == "seçiniz..." || string.IsNullOrEmpty(txtFaturaTutari.Text) == true)
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz!", "Temin Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // int dosyaNo = Convert.ToInt32(txtDosyaNo.Text);
                    if (db.Teminler.Any(x => x.DosyaNo == txtDosyaNo.Text && x.Id != _id))
                    {
                        MessageBox.Show("Aynı Dosya No' ya sahip kayıt zaten var.", "Temin Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        temin.DosyaNo = txtDosyaNo.Text;
                        temin.IsinAdi = txtIsinAdi.Text;
                        temin.IsiYapanFirma = Convert.ToInt32(cmbFirmaAdi.SelectedValue);
                        temin.TeminSekli = Convert.ToInt32(cmbTeminSekli.SelectedValue);
                        temin.TeminTipi = Convert.ToInt32(cmbTeminTipi.SelectedValue);
                        temin.TeminTuru = Convert.ToInt32(cmbTeminTuru.SelectedValue);
                        temin.Aciklama = txtAciklama.Text;
                        temin.DosyaYolu = txtDosyaYolu.Text;
                        temin.TeminTarihi = dateTimePicker1.Value;
                        temin.FaturaTutar = Convert.ToDecimal(txtFaturaTutari.Text);
                        db.SaveChanges();
                        Temizle();
                        TümTeminleriGetir();
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Temin Güncelleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }
    }
}
