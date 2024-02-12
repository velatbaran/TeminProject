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
    public partial class frmTeminSekli : Form
    {
        private TeminDbEntities db = new TeminDbEntities();
        private TeminSekilleri teminSekilleri = new TeminSekilleri();

        public frmTeminSekli()
        {
            InitializeComponent();
        }

        private void TeminSekilleriDoldur()
        {
            listTeminSekilleri.DisplayMember = "SekilAd";
            listTeminSekilleri.ValueMember = "Id";
            listTeminSekilleri.DataSource = db.TeminSekilleri.OrderByDescending(a => a.Id).ToList();
        }

        private void btnTeminSekliKaydet_Click(object sender, EventArgs e)
        {
            if (txtTeminSekli.Text != "")
            {
                if (db.TeminSekilleri.Any(x => x.SekilAd.ToLower() == txtTeminSekli.Text.ToLower()))
                {
                    MessageBox.Show("Bu temin şekli zaten kayıtlı!", "Temin Sekli Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    teminSekilleri.SekilAd = txtTeminSekli.Text;
                    db.TeminSekilleri.Add(teminSekilleri);
                    db.SaveChanges();
                    TeminSekilleriDoldur();
                    txtTeminSekli.Clear();
                    txtTeminSekli.Focus();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.", "Temin Sekli Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //  UrunKategoriDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "Temin Sekli Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnTeminSekliSil_Click(object sender, EventArgs e)
        {
            try
            {
                int teminSekilId = Convert.ToInt32(listTeminSekilleri.SelectedValue.ToString());
                string teminSekli = listTeminSekilleri.Text;
                DialogResult onay = MessageBox.Show(teminSekli + " temin şeklini silmek istediğinize emin misiniz?", "Temin Sekli Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var bul = db.TeminSekilleri.FirstOrDefault(x => x.Id == teminSekilId);
                    db.TeminSekilleri.Remove(bul);
                    db.SaveChanges();
                    TeminSekilleriDoldur();
                    txtTeminSekli.Clear();
                    txtTeminSekli.Focus();
                    MessageBox.Show("Silme işlemi başarıyla gerçekleşti.", "Temin Sekli Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    // UrunKategoriDoldur();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Temin Sekli Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Temin Sekli Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

        }

        private void btnTeminSekliGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTeminSekli.Text != "")
            {
                int id = Convert.ToInt32(listTeminSekilleri.SelectedValue);
                var teminSekli = db.TeminSekilleri.Find(id);
                if (teminSekli == null)
                {
                    MessageBox.Show("Kayıt bulunamadı!", "Temin Sekli Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    if (db.TeminSekilleri.Any(x => x.SekilAd.ToLower() == txtTeminSekli.Text.ToLower()))
                    {
                        MessageBox.Show("Bu temin şekli zaten kayıtlı!", "Temin Sekli Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        teminSekli.SekilAd = txtTeminSekli.Text;
                        db.SaveChanges();
                        TeminSekilleriDoldur();
                        txtTeminSekli.Clear();
                        txtTeminSekli.Focus();
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Temin Sekli Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        // UrunKategoriDoldur();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Temin Sekli Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void listTeminSekilleri_MouseClick(object sender, MouseEventArgs e)
        {
            txtTeminSekli.Text = listTeminSekilleri.Text;
        }

        private void frmTeminSekli_Load(object sender, EventArgs e)
        {
            TeminSekilleriDoldur();
        }
    }
}
