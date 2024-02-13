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
    public partial class frmTeminler : Form
    {
        TeminDbEntities db = new TeminDbEntities();
        public frmTeminler()
        {
            InitializeComponent();
        }

        private void teminTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeminTipi frm = new frmTeminTipi();
            frm.ShowDialog();
        }

        private void teminTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeminTur frm = new frmTeminTur();
            frm.ShowDialog();
        }

        private void teminŞekilleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeminSekli frm = new frmTeminSekli();
            frm.ShowDialog();
        }

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirmalar frm = new frmFirmalar();
            frm.ShowDialog();
        }

        private void firmaTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirmaTuru frm = new frmFirmaTuru();
            frm.ShowDialog();
        }

        private void frmTeminler_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTeminler_Load(object sender, EventArgs e)
        {
            TümTeminler();
            lblToplamKayit.Text = Convert.ToString(gridTeminler.Rows.Count);
        }

        public void TümTeminler()
        {
            //gridTeminler.DataSource = (from k in db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri").ToList()
            //                          select new { k.Id, k.DosyaNo, k.IsinAdi, k.Firmalar.FirmaAd, k.TeminSekilleri.SekilAd, k.TeminTürleri.TurAd, k.TeminTipleri.TipAd }).ToList();
            gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                        .Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd,x.TeminTarihi ,x.FaturaTutar}).OrderByDescending(x=>x.TeminTarihi).ToList();
            lblToplamKayit.Text = Convert.ToString(gridTeminler.Rows.Count);
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            frmTeminEkle frm = new frmTeminEkle();
            frm.ShowDialog();
        }

        private void btnfirmaGuncelle_Click(object sender, EventArgs e)
        {
            frmTeminGuncelle frm = new frmTeminGuncelle();
            int seciliAlan = gridTeminler.SelectedCells[0].RowIndex;
            frm.lblTeminId.Text = gridTeminler.Rows[seciliAlan].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void btnFirmaDetay_Click(object sender, EventArgs e)
        {
            frmTeminDetay frm = new frmTeminDetay();
            int seciliAlan = gridTeminler.SelectedCells[0].RowIndex;
            frm.lblTeminId.Text = gridTeminler.Rows[seciliAlan].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridTeminler.Rows.Count > 0)
            {
                int seciliAlan = gridTeminler.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(gridTeminler.Rows[seciliAlan].Cells[0].Value.ToString());
                string teminAdi = gridTeminler.Rows[seciliAlan].Cells[2].Value.ToString();
                DialogResult onay = MessageBox.Show(teminAdi + " temin kaydını silmek istdeğinize emin misiniz?", "Temin Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay == DialogResult.Yes)
                {
                    var temin = db.Teminler.Find(id);
                    db.Teminler.Remove(temin);
                    db.SaveChanges();
                    MessageBox.Show("Temin silme işlemi başarılıyla gerçekleşti.", "Temin Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    TümTeminler();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "Temin Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void txtTeminAra_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (rdFirma.Checked == true)
                {
                    if (txtTeminAra.Text == "")
                        TümTeminler();
                    else
                        gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                                                .Where(x => x.Firmalar.FirmaAd.ToLower().Contains(txtTeminAra.Text.ToLower())).Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd,x.TeminTarihi, x.FaturaTutar }).OrderByDescending(x => x.TeminTarihi).ToList();

                }
                else if (rdIsinAdi.Checked == true)
                {
                    if (txtTeminAra.Text == "")
                        TümTeminler();
                    else
                        gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                                            .Where(x => x.IsinAdi.ToLower().Contains(txtTeminAra.Text.ToLower())).Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd, x.TeminTarihi, x.FaturaTutar }).OrderByDescending(x => x.TeminTarihi).ToList();
                }
                else if (rdTeminSekli.Checked == true)
                {
                    if (txtTeminAra.Text == "")
                        TümTeminler();
                    else
                        gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                                            .Where(x => x.TeminSekilleri.SekilAd.ToLower().Contains(txtTeminAra.Text.ToLower())).Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd, x.TeminTarihi, x.FaturaTutar }).OrderByDescending(x => x.TeminTarihi).ToList();
                }
                else if (rdTeminTipi.Checked == true)
                {
                    if (txtTeminAra.Text == "")
                        TümTeminler();
                    else
                        gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                                            .Where(x => x.TeminTipleri.TipAd.ToLower().Contains(txtTeminAra.Text.ToLower())).Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd, x.TeminTarihi, x.FaturaTutar }).OrderByDescending(x => x.TeminTarihi).ToList();
                }
                else if (rdTeminYili.Checked == true)
                {
                    if (txtTeminAra.Text == "")
                        TümTeminler();
                    else
                        gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                                            .Where(x => x.TeminTarihi.Value.Year.ToString().Contains(txtTeminAra.Text.ToLower())).Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd, x.TeminTarihi, x.FaturaTutar }).OrderByDescending(x => x.TeminTarihi).ToList();
                }
                else if (r5dTeminTuru.Checked == true)
                {
                    //gridTeminler.DataSource = (from k in db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri").ToList()
                    //                           select new { k.Id, k.DosyaNo, k.IsinAdi, k.Firmalar.FirmaAd, k.TeminSekilleri.SekilAd, k.TeminTürleri.TurAd, k.TeminTipleri.TipAd ,x.TeminTarihi})
                    //       .Where(a => a.TurAd.ToLower().Contains(txtTeminAra.Text.ToLower())).ToList();

                    if (txtTeminAra.Text == "")
                        TümTeminler();
                    else
                        gridTeminler.DataSource = db.Teminler.Include("Firmalar").Include("TeminSekilleri").Include("TeminTipleri").Include("TeminTürleri")
                                                            .Where(x => x.TeminTürleri.TurAd.ToLower().Contains(txtTeminAra.Text.ToLower())).Select(x => new { x.Id, x.DosyaNo, x.IsinAdi, x.Firmalar.FirmaAd, x.TeminSekilleri.SekilAd, x.TeminTürleri.TurAd, x.TeminTipleri.TipAd, x.TeminTarihi, x.FaturaTutar }).OrderByDescending(x => x.TeminTarihi).ToList();

                }

                lblToplamKayit.Text = Convert.ToString(gridTeminler.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TümTeminler();
            lblToplamKayit.Text = Convert.ToString(gridTeminler.Rows.Count);
        }

        private void btnFirmaRaporAl_Click(object sender, EventArgs e)
        {
            if (gridTeminler.Rows.Count == 0)
            {
                MessageBox.Show("Raporda gösterilecek ürün bulunamadı!");
            }
            else
            {
                Raporlar.RaporSayfasi(gridTeminler);
            }
        }

        private void istatistikleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIstatisler frm = new frmIstatisler();
            frm.ShowDialog();
        }
    }
}
