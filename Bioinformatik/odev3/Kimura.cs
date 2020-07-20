using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    class Kimura
    {
        public void UzaklıkHesapla(string birinci_sekans, string ikinci_sekans)
        {
            double K;
            double transition = 0;
            double transversion = 0;
            double sekansuzunluk = birinci_sekans.Length;
            for (int i = 0; i < birinci_sekans.Length; i++)
            {
                if (birinci_sekans[i] == 'A' && ikinci_sekans[i] == 'T' || birinci_sekans[i] == 'A' && ikinci_sekans[i] == 'C' ||
                    birinci_sekans[i] == 'T' && ikinci_sekans[i] == 'A' || birinci_sekans[i] == 'T' && ikinci_sekans[i] == 'G' ||
                    birinci_sekans[i] == 'G' && ikinci_sekans[i] == 'T' || birinci_sekans[i] == 'G' && ikinci_sekans[i] == 'C' ||
                    birinci_sekans[i] == 'C' && ikinci_sekans[i] == 'A' || birinci_sekans[i] == 'C' && ikinci_sekans[i] == 'G')
                {
                    transversion++;
                    
                }
                else if (birinci_sekans[i] == 'A' && ikinci_sekans[i] == 'G' || birinci_sekans[i] == 'G' && ikinci_sekans[i] == 'A' ||
                         birinci_sekans[i] == 'C' && ikinci_sekans[i] == 'T' || birinci_sekans[i] == 'T' && ikinci_sekans[i] == 'C')
                    
                {
                    transition++;   
                }
            }
            K = 0.5 * Math.Log(1 / (1 - ((2 * transition) / sekansuzunluk) - (transversion / sekansuzunluk))) + 0.25 * Math.Log(1 / (1 - (2 * transversion) / sekansuzunluk));
            if (K < 0.75 && K > 0)
            {
                Console.WriteLine("Kimura Oranı:" + K);
            }
            else
            {
                Console.WriteLine("Kimura Oranı:0-0,75 arasında olmalıdır");
            }
        }
    }
}
