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
    public partial class frmTeminTipi : Form
    {
        private TeminDbEntities db = new TeminDbEntities();
        private TeminTipleri teminTipleri = new TeminTipleri();

        public frmTeminTipi()
        {
            InitializeComponent();
        }

        private void TeminTipleriDoldur()
        {
            listTeminTipleri.DisplayMember = "TipAd";
            listTeminTipleri.ValueMember = "Id";
            listTeminTipleri.DataSource = db.TeminTipleri.OrderByDescending(a => a.Id).ToList();
        }           

        private void btnTeminTipiKaydet_Click(object sender, EventArgs e)
        {
            if (txtTeminTipi.Text != "")
            {
                if (db.TeminTipleri.Any(x => x.TipAd.ToLower() == txtTeminTipi.Text.ToLower()))
                {
                    MessageBox.Show("Temin tipi zaten kayıtlı!", "Temin Tipi Ekmele İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    teminTipleri.TipAd = txtTeminTipi.Text;
                    db.TeminTipleri.Add(teminTipleri);
                    db.SaveChanges();
                    TeminTipleriDoldur();
                    txtTeminTipi.Clear();
                    txtTeminTipi.Focus();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.", "Temin Tipi Ekmele İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //  UrunKategoriDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "Temin Tipi Ekmele İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnTeminTipiSil_Click(object sender, EventArgs e)
        {
            try
            {
                int teminTipId = Convert.ToInt32(listTeminTipleri.SelectedValue.ToString());
                string teminTipi = listTeminTipleri.Text;
                DialogResult onay = MessageBox.Show(teminTipi + " temin tipini silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var bul = db.TeminTipleri.FirstOrDefault(x => x.Id == teminTipId);
                    db.TeminTipleri.Remove(bul);
                    db.SaveChanges();
                    TeminTipleriDoldur();
                    txtTeminTipi.Clear();
                    txtTeminTipi.Focus();
                    MessageBox.Show("Silme işlemi başarıyla gerçekleşti.", "Temin Tipi Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void frmTeminTipi_Load(object sender, EventArgs e)
        {
            TeminTipleriDoldur();
        }

        private void btnTeminTipGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTeminTipi.Text != "")
            {
                int id = Convert.ToInt32(listTeminTipleri.SelectedValue);
                var teminTipi = db.TeminTipleri.Find(id);
                if (teminTipi == null)
                {
                    MessageBox.Show("Kayıt bulunamadı!", "Temin Tipi Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    if (db.TeminTipleri.Any(x => x.TipAd.ToLower() == txtTeminTipi.Text.ToLower()))
                    {                       
                        MessageBox.Show("Temin tipi zaten kayıtlı!", "Temin Tipi Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        teminTipi.TipAd = txtTeminTipi.Text;
                        db.SaveChanges();
                        TeminTipleriDoldur();
                        txtTeminTipi.Clear();
                        txtTeminTipi.Focus();
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Temin Tipi Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                }             
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Temin Tipi Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void listTeminTipleri_MouseClick(object sender, MouseEventArgs e)
        {
            txtTeminTipi.Text = listTeminTipleri.Text;
        }
    }
}
