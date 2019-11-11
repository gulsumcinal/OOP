using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    abstract class Tatil
    {
        protected int izin;
        public string Birikim()
        {
            return "MUTLULUK";
        }
        public virtual int YillikIzin()
        {
            return 15;
        }
        public abstract string GidilecekYer();
        public abstract string KalacakYer();
        public abstract string Ulasim();
        public string YazEtkinlik()
        {
            return "Yamaç Paraşütü";
        }
        public string KisEtkinlik1()
        {
            return "Kayak";
        }
        public string KisEtkinlik2()
        {
            return "Kuzey Işıkları'nı İzlemek";
        }
        protected virtual int CadirSayisi()
        {
            return 1;
        }
        private int Emeklilik()
        {
            izin = 365;
            return izin;
        }
    }
}
