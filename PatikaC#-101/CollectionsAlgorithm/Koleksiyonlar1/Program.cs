using System;
using System.Collections;

namespace Koleksiyonlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayi = new ArrayList();
            ArrayList normalSayi = new ArrayList();

            int enBuyukAsal = 0;
            int enBuyukNormal = 0;
            for (int i = 1; i <= 20; i++)
            {


                Console.Write("{0}. sayıyı girin : ", i);
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (i % 2 == 0 || i % i == 1)
                {
                    asalSayi.Add(sayi);
                    if (sayi > enBuyukAsal)
                        enBuyukAsal = sayi;
                }
                else
                {
                    normalSayi.Add(sayi);
                    if (sayi > enBuyukAsal)
                        enBuyukNormal = sayi;
                }


            }


            foreach (var item in asalSayi)
            {
                Console.Write("Asal sayılar : ");
                Console.WriteLine(item);

            }

            Console.WriteLine("Asal eleman sayısı : {0}", asalSayi.Count);


            Console.Write("En Büyük Asal Sayı {0} : ", enBuyukAsal);

            foreach (var item in normalSayi)
            {
                Console.Write("Normal sayılar : ");
                Console.WriteLine(item);

            }

            Console.WriteLine("Normal eleman sayısı : {0}", normalSayi.Count);

            Console.Write("En Büyük Normal Sayı {0} : ", enBuyukNormal);


        }

    }
}
