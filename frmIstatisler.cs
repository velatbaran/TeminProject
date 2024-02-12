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
    public partial class frmIstatisler : Form
    {
        public frmIstatisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIstatistihCalisilanFirmalar frm = new frmIstatistihCalisilanFirmalar();
            frm.ShowDialog();
        }
    }
}
