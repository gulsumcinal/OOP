using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    class YazTatili : Tatil
    {
        public override string GidilecekYer()
        {
            return "Fethiye";
        }
        public override string KalacakYer()
        {
            return "Yazlık";
        }
        public override string Ulasim()
        {
            return "Şahsi Araç";
        }
        public string EtkinlikY()
        {
            return "Yamaç Paraşütü";
        }
    }
}
