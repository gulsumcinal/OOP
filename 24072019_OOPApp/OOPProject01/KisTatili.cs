using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    class KisTatili : Tatil
    {
        public override int YillikIzin()
        {
            return 7;
        }
        public override string GidilecekYer()
        {
            return "Norveç";
        }
        public override string KalacakYer()
        {
            return "Bungalow";
        }
        public override string Ulasim()
        {
            return "Uçak";
        }
        private int OtelOdaNo()
        {
            return 369;
        }
    }
}
