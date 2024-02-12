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
    public partial class frmIstatistihCalisilanFirmalar : Form
    {
        TeminDbEntities db = new TeminDbEntities();
        public frmIstatistihCalisilanFirmalar()
        {
            InitializeComponent();
        }

        private void frmIstatistihCalisilanFirmalar_Load(object sender, EventArgs e)
        {
            cmbIstatistikYil.Text = "seçiniz...";
        }

        private void btnIstatistikFirmaGetir_Click(object sender, EventArgs e)
        {
            if (cmbIstatistikYil.Text != "seçiniz...")
            {
                int yil = Convert.ToInt32(cmbIstatistikYil.Text);
                gridIstatistikTeminler.DataSource = db.Teminler.Include("Firmalar").Where(x => x.TeminTarihi.Value.Year == yil).GroupBy(x => x.Firmalar.SicilNo).ToList();
            }
        }
    }
}
