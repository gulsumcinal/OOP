using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject03
{
    public class BAU
    {
        // BAU class'ı veri üretmek için hazırlanmıştır.
        string[] Adlar = { "Şamil", "Cemal", "Ali", "Murat", "Kemal", "Şahin", "Hüseyin" };
        string[] Soyadlar = { "Yıldız", "Erkmen", "Kahraman", "Erdemir"};
        string[] Sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana"};

        public string[] SehirlerArray
        {
            get
            {
                return Sehirler;
            }
        }

        static Random rnd = new Random();
        public string GetName()
        {
            int indexName = rnd.Next(0, Adlar.Length);
            return Adlar[indexName];
        }
        public string GetSurname()
        {
            int indexSurname = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[indexSurname];
        }
        public string GetCity()
        {
            int indexCity = rnd.Next(0, Sehirler.Length);
            return Sehirler[indexCity];
        }
        public DateTime GetBackDate(int year)
        {
            int rndYear = rnd.Next(0, year);
            DateTime newDate = DateTime.Today.AddYears(-rndYear);
            return newDate;
        }
        public DateTime GetForwardDate(int year)
        {
            int addYear = rnd.Next(0, year);
            DateTime nextDate = DateTime.Today.AddYears(addYear);
            return nextDate;
        }
        public LifeDurationInfo GetLifeDurations(DateTime birthDate)
        {
            LifeDurationInfo lfd = new LifeDurationInfo();

            int ty = DateTime.Now.Year - birthDate.Year;
            lfd.calculatedAge = ty;

            TimeSpan ts = DateTime.Now.Subtract(birthDate);
            
            double td = ts.TotalDays;
            lfd.calculatedDays = td;

            double th = ts.TotalHours;
            lfd.calculatedHours = th;

            double tm = ts.TotalMinutes;
            lfd.calculatedMinutes = tm;

            double tsc = ts.TotalSeconds;
            lfd.calculatedSeconds = tsc;

            double tmsc = ts.TotalMilliseconds;
            lfd.calculatedMilliseconds = tmsc;

            return lfd;
        }
    }
}
