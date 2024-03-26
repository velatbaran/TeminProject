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
    public partial class frmFirmalar : Form
    {
        TeminDbEntities db = new TeminDbEntities();

        public frmFirmalar()
        {
            InitializeComponent();
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            frmFirmaEkle frm = new frmFirmaEkle();
            frm.ShowDialog();
        }

        private void btnfirmaGuncelle_Click(object sender, EventArgs e)
        {
            frmFirmaGuncelle frm = new frmFirmaGuncelle();
            int seciliAlan = gridFirmalar.SelectedCells[0].RowIndex;
            frm.lblFirmaId.Text = gridFirmalar.Rows[seciliAlan].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        public void TümFirmalar()
        {
            gridFirmalar.DataSource = (from k in db.Firmalar.Include("FirmaTurleri").ToList()
                                       select new { k.Id, k.FirmaAd, k.YetkiliKisi, k.FirmaTurleri.FirmaTurAd ,k.SicilNo, k.VergiDairesi, k.VergiNo, k.Telefon, k.Email }).ToList();
                           
        }

        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            TümFirmalar();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirmaGuncelle frm = new frmFirmaGuncelle();
            int seciliAlan = gridFirmalar.SelectedCells[0].RowIndex;
            frm.lblFirmaId.Text = gridFirmalar.Rows[seciliAlan].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridFirmalar.Rows.Count > 0)
            {
                int seciliAlan = gridFirmalar.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(gridFirmalar.Rows[seciliAlan].Cells[0].Value.ToString());
                string firmaAdi = gridFirmalar.Rows[seciliAlan].Cells[2].Value.ToString();
                DialogResult onay = MessageBox.Show(firmaAdi + " firmasını silmek istdeğinize emin misiniz?", "Firma Silme İşlemi", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var firma = db.Firmalar.Find(id);
                    db.Firmalar.Remove(firma);
                    db.SaveChanges();
                    MessageBox.Show("Firma silme işlemi başarılıyla gerçekleşti.", "Firma Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    TümFirmalar();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Firma Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridFirmalar.Rows.Count > 0)
            {
                int seciliAlan = gridFirmalar.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(gridFirmalar.Rows[seciliAlan].Cells[0].Value.ToString());
                string firmaAdi = gridFirmalar.Rows[seciliAlan].Cells[2].Value.ToString();
                DialogResult onay = MessageBox.Show(firmaAdi + " firmasını silmek istdeğinize emin misiniz?", "Firma Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var firma = db.Firmalar.Find(id);
                    db.Firmalar.Remove(firma);
                    db.SaveChanges();
                    MessageBox.Show("Firma silme işlemi başarılıyla gerçekleşti.", "Firma Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    TümFirmalar();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Firma Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFirmaDetay_Click(object sender, EventArgs e)
        {
            frmFirmaDetay frm = new frmFirmaDetay();
            int seciliAlan = gridFirmalar.SelectedCells[0].RowIndex;
            frm.lblFirmaId.Text = gridFirmalar.Rows[seciliAlan].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirmaDetay frm = new frmFirmaDetay();
            int seciliAlan = gridFirmalar.SelectedCells[0].RowIndex;
            frm.lblFirmaId.Text = gridFirmalar.Rows[seciliAlan].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void frmFirmalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Çıkmak istiyor musunuz?", "Firmalar Sayfası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void txtfirmaAra_TextChanged(object sender, EventArgs e)
        {
            if (txtfirmaAra.Text == "")
                TümFirmalar();
            else
                gridFirmalar.DataSource = (from k in db.Firmalar.Include("FirmaTurleri").ToList()
                                           where k.FirmaAd.ToLower().Contains(txtfirmaAra.Text.ToLower()) || k.YetkiliKisi.ToLower().Contains(txtfirmaAra.Text.ToLower())
                                           select new { k.Id, k.FirmaAd, k.YetkiliKisi, k.FirmaTurleri.FirmaTurAd, k.SicilNo, k.VergiDairesi, k.VergiNo, k.Telefon, k.Email }).ToList();
        }
    }
}
