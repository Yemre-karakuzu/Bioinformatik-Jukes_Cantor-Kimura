using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    class Jukes_Cantor
    {
        public void UzaklıkHesapla(string birinci_sekans, string ikinci_sekans)
        {
            double toplam=0;
            for (int i = 0; i < birinci_sekans.Length; i++)
            {
                if(birinci_sekans[i]!=ikinci_sekans[i])
                {
                    toplam++;
                }
            }
            double sekansuzunluk = birinci_sekans.Length;
            //double P =toplam /sekansuzunluk;
            double P =15.0/100.0;
            double K1 = Math.Log(1 - ((4 / 3) * P));
            double K = -(3.0 / 4.0)*K1;
            
            
            if(K<0.75 && K>0)
            {
                Console.WriteLine("Jukes Cantor Oranı:" + K);
            }
            else
            {
                Console.WriteLine("Jukes Cantor Oranı:0-0,75 arasında olmalıdır");
            }
            
        }
    }
}
