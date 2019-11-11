using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    class HaftaSonuTatili : Tatil
    {
        public override int YillikIzin()
        {
            return 2;
        }
        public override string GidilecekYer()
        {
            return "Kilimli Koyu";
        }
        public override string KalacakYer()
        {
            return "Çadır";
        }
        public override string Ulasim()
        {
            return "Otostop";
        }
        public string KampEtkinlik()
        {
            return "Mangal";
        }
    }
}
