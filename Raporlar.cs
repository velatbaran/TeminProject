using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeminProject
{
    static class Raporlar
    {
        public static string Baslik { get; set; }
        public static string ToplamTeminSayisi { get; set; }

        public static void RaporSayfasi(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<TeminlerRapor> listTeminler = new List<TeminlerRapor>();
            listTeminler.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                listTeminler.Add(new TeminlerRapor
                {
                    Id = Convert.ToInt32(dgv.Rows[i].Cells["Id"].Value?.ToString()),
                    DosyaNo = dgv.Rows[i].Cells["DosyaNo"].Value?.ToString(),
                    IsinAdi = dgv.Rows[i].Cells["IsinAdi"].Value?.ToString(),
                    FirmaAd = dgv.Rows[i].Cells["FirmaAd"].Value?.ToString(),
                    SekilAd = dgv.Rows[i].Cells["SekilAd"].Value?.ToString(),
                    TurAd = dgv.Rows[i].Cells["TurAd"].Value?.ToString(),
                    TipAd = dgv.Rows[i].Cells["TipAd"].Value?.ToString(),
                    FaturaTutar = Convert.ToDecimal(dgv.Rows[i].Cells["FaturaTutar"].Value?.ToString()),
                    TeminTarihi = dgv.Rows[i].Cells["TeminTarihi"].Value?.ToString(),
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsGenelRapor";
            rs.Value = listTeminler;
            frmRaporGoster frm = new frmRaporGoster();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpGenelRapor.rdlc";
            frm.reportViewer1.LocalReport.Refresh();
            frm.reportViewer1.RefreshReport();

            frm.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
    }
}
