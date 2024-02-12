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
    public partial class frmTeminTur : Form
    {
        private TeminDbEntities db = new TeminDbEntities();
        private TeminTürleri teminTurleri = new TeminTürleri();
        public frmTeminTur()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTeminTuru.Text != "")
            {
                if (db.TeminTürleri.Any(x => x.TurAd.ToLower() == txtTeminTuru.Text.ToLower()))
                {
                    MessageBox.Show("Bu temin türü zaten kayıtlı!", "Temin Tür Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    teminTurleri.TurAd = txtTeminTuru.Text;
                    db.TeminTürleri.Add(teminTurleri);
                    db.SaveChanges();
                    TeminTurleriDoldur();
                    txtTeminTuru.Clear();
                    txtTeminTuru.Focus();
                    MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti.", "Temin Tür Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //  UrunKategoriDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanı doldurunuz!", "Temin TürEkleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void frmTeminTur_Load_1(object sender, EventArgs e)
        {
            TeminTurleriDoldur();
        }

        private void TeminTurleriDoldur()
        {
            listTeminTurleri.DisplayMember = "TurAd";
            listTeminTurleri.ValueMember = "Id";
            listTeminTurleri.DataSource = db.TeminTürleri.OrderByDescending(a => a.Id).ToList();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                int teminTurId = Convert.ToInt32(listTeminTurleri.SelectedValue.ToString());
                string teminTuru = listTeminTurleri.Text;
                DialogResult onay = MessageBox.Show(teminTuru + " temin türünü silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var bul = db.TeminTürleri.FirstOrDefault(x => x.Id == teminTurId);
                    db.TeminTürleri.Remove(bul);
                    db.SaveChanges();
                    TeminTurleriDoldur();
                    txtTeminTuru.Clear();
                    txtTeminTuru.Focus();
                    MessageBox.Show("Silme işlemi başarıyla gerçekleşti.", "Temin Tür Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    // UrunKategoriDoldur();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Temin Tür Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Temin Tür Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTeminTuru.Text != "")
            {
                int id = Convert.ToInt32(listTeminTurleri.SelectedValue);
                var teminTuru = db.TeminTürleri.Find(id);
                if (teminTuru == null)
                {
                    MessageBox.Show("Kayıt bulunamadı!", "Temin Tür Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    if (db.TeminTürleri.Any(x => x.TurAd.ToLower() == txtTeminTuru.Text.ToLower()))
                    {
                        MessageBox.Show("Bu temin türü zaten kayıtlı!", "Temin Tür Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        teminTuru.TurAd = txtTeminTuru.Text;
                        db.SaveChanges();
                        TeminTurleriDoldur();
                        txtTeminTuru.Clear();
                        txtTeminTuru.Focus();
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Temin Tür Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        //  UrunKategoriDoldur();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Temin Tür Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

        }

        private void listTeminTurleri_MouseClick(object sender, MouseEventArgs e)
        {
            txtTeminTuru.Text = listTeminTurleri.Text;
        }
    }
}
