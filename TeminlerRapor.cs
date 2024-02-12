using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeminProject
{
    public class TeminlerRapor
    {
        public int Id { get; set; }
        public string DosyaNo { get; set; }
        public string IsinAdi { get; set; }
        public string FirmaAd { get; set; }
        public string SekilAd { get; set; }
        public string TurAd { get; set; }
        public string TipAd { get; set; }
        public decimal FaturaTutar { get; set; }
        public string TeminTarihi { get; set; }
    }
}
