using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            string birinci_sekans;
            string ikinci_sekans;
            Jukes_Cantor oran_Juke = new Jukes_Cantor();
            Kimura oran_Kimura = new Kimura();
            loop:
            Console.WriteLine("Lütfen Büyük Harfle Yazınız.");
            Console.WriteLine("Lütfen birinci sekansi giriniz!");
            birinci_sekans = Console.ReadLine();
            Console.WriteLine("Lütfen ikini sekansi giriniz!");
            ikinci_sekans = Console.ReadLine();
            if(birinci_sekans.Length==ikinci_sekans.Length)
            {
                oran_Juke.UzaklıkHesapla(birinci_sekans, ikinci_sekans);
                oran_Kimura.UzaklıkHesapla(birinci_sekans, ikinci_sekans);
            }
            else
            {
                Console.WriteLine("Lütfen sekanslari eşit giriniz!");
                goto loop;
            }
            Console.ReadKey();
        }
        
    }
}
