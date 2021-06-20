using System;
using System.Collections;

namespace Koleksiyonlar2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList sayilar = new ArrayList();

            int enBuyuk = 0;
            int enBuyuk2 = 0;
            int enBuyuk3 = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz : ", i);
                 sayilar[i] = Console.ReadLine();



            }
        }
    }
}
