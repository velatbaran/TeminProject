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
    public partial class frmFirmaTuru : Form
    {
        private TeminDbEntities db = new TeminDbEntities();
        private FirmaTurleri firmaTurleri = new FirmaTurleri();

        public frmFirmaTuru()
        {
            InitializeComponent();
        }

        private void FirmaTurleriDoldur()
        {
            listFirmaTurleri.DisplayMember = "FirmaTurAd";
            listFirmaTurleri.ValueMember = "Id";
            listFirmaTurleri.DataSource = db.FirmaTurleri.OrderByDescending(a => a.Id).ToList();
        }

        private void frmFirmaTuru_Load(object sender, EventArgs e)
        {
            FirmaTurleriDoldur();
        }

        private void listFirmaTurleri_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirmaTuru.Text = listFirmaTurleri.Text;
        }

        private void btnFirmaTuruKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirmaTuru.Text != "")
            {
                if (db.FirmaTurleri.Any(x => x.FirmaTurAd.ToLower() == txtFirmaTuru.Text.ToLower()))
                {
                    MessageBox.Show("Bu firma türü zaten kayıtlı!", "Firma Türü Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    firmaTurleri.FirmaTurAd = txtFirmaTuru.Text;
                    db.FirmaTurleri.Add(firmaTurleri);
                    db.SaveChanges();
                    FirmaTurleriDoldur();
                    txtFirmaTuru.Clear();
                    txtFirmaTuru.Focus();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.", "Firma Türü Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //  UrunKategoriDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "Firma Türü Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnFirmaTuruGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFirmaTuru.Text != "")
            {
                int id = Convert.ToInt32(listFirmaTurleri.SelectedValue);
                var firmaTuru = db.FirmaTurleri.Find(id);
                if (firmaTuru == null)
                {
                    MessageBox.Show("Kayıt bulunamadı!", "Firma Türü Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    if (db.FirmaTurleri.Any(x => x.FirmaTurAd.ToLower() == txtFirmaTuru.Text.ToLower()))
                    {
                        MessageBox.Show("Bu firma türü zaten kayıtlı!", "Firma Türü Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        firmaTuru.FirmaTurAd = txtFirmaTuru.Text;
                        db.SaveChanges();
                        FirmaTurleriDoldur();
                        txtFirmaTuru.Clear();
                        txtFirmaTuru.Focus();
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Firma Türü Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        // UrunKategoriDoldur();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Firma Türü Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnFirmaTuruSil_Click(object sender, EventArgs e)
        {
            try
            {
                int firmaTuruId = Convert.ToInt32(listFirmaTurleri.SelectedValue.ToString());
                string firmaTuru = listFirmaTurleri.Text;
                DialogResult onay = MessageBox.Show(firmaTuru + " firma türünü silmek istediğinize emin misiniz?", "Firma Türü Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var bul = db.FirmaTurleri.FirstOrDefault(x => x.Id == firmaTuruId);
                    db.FirmaTurleri.Remove(bul);
                    db.SaveChanges();
                    FirmaTurleriDoldur();
                    txtFirmaTuru.Clear();
                    txtFirmaTuru.Focus();
                    MessageBox.Show("Silme işlemi başarıyla gerçekleşti.", "Firma Türü Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Firma Türü Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Firma Türü Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

        }
    }
}
