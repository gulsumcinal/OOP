using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sizin için tanımlı tatil programlarımız mevcuttur. ");
            Console.WriteLine("Aşağıdaki programlardan inceleyip rezervasyon yaptırabilirsiniz.");
            Console.WriteLine();
            KisTatili kt = new KisTatili();
            Console.WriteLine("Kış aylarında keyifli bir tatil yapmak mı istiyorsunuz?");
            Console.WriteLine("Bu program tam size göre!");
            Console.WriteLine();
            Console.WriteLine("Program Süresi: " + kt.YillikIzin());
            Console.WriteLine();
            Console.WriteLine("Gidilecek Yer: " + kt.GidilecekYer());
            Console.WriteLine();
            Console.WriteLine("Kalacak Yer: " + kt.KalacakYer());
            Console.WriteLine();
            Console.WriteLine("Ulaşım Şekli: " + kt.Ulasim());
            Console.WriteLine();
            Console.WriteLine("***Bu tatile tanımlı iki etkinliğimiz bulunmaktadır: "
                + kt.KisEtkinlik1() + " ve " + kt.KisEtkinlik2());
            Console.WriteLine();
            Console.WriteLine("İYİ TATİLLER!!!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();

            Console.WriteLine("\" Benim için tatil deniz-kum-güneş demek!!\" diyenlerden misiniz?");
            Console.WriteLine("Hayallerinizdeki tatil Fethiye'de!");
            Console.WriteLine();
            YazTatili yt = new YazTatili();
            Console.WriteLine("Tatil bilgileriniz aşağıda bulunmaktadır.");
            Console.WriteLine();
            Console.WriteLine("Program Süresi: " + yt.YillikIzin());
            Console.WriteLine();
            Console.WriteLine("Gidilecek Yer: " + yt.GidilecekYer());
            Console.WriteLine();
            Console.WriteLine("Kalacak Yer: " + yt.KalacakYer());
            Console.WriteLine();
            Console.WriteLine("Ulaşım Şekli: " + yt.Ulasim());
            Console.WriteLine();
            Console.WriteLine("***Bu tatile tanımlı etkinliğimiz bulunmaktadır: " + yt.YazEtkinlik());
            Console.WriteLine();
            Console.WriteLine("İYİ TATİLLER!!!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();

            Console.WriteLine("Tatil yapmaya zamanınız mı yok? O zaman bir hafta sonu kaçamağı yapmaya ne dersiniz?");
            Console.WriteLine();
            HaftaSonuTatili ht = new HaftaSonuTatili();
            Console.WriteLine("Tatil bilgileriniz aşağıda bulunmaktadır.");
            Console.WriteLine();
            Console.WriteLine("Program Süresi: " + ht.YillikIzin());
            Console.WriteLine();
            Console.WriteLine("Gidilecek Yer: " + ht.GidilecekYer());
            Console.WriteLine();
            Console.WriteLine("Kalacak Yer: " + ht.KalacakYer());
            Console.WriteLine();
            Console.WriteLine("Ulaşım Şekli: " + ht.Ulasim());
            Console.WriteLine();
            Console.WriteLine(ht.KampEtkinlik() + " yapmak için alanlarımız mevcuttur.");
            Console.WriteLine();
            Console.WriteLine("İYİ TATİLLER!!!");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Küçük bir tatil, büyük bir " + ht.Birikim() + "    :)");
            Console.ReadLine();

        }
    }
}
