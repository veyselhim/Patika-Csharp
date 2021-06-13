using System;

namespace ODEV_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Kaç adet sayı gireceksiniz ? ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("M sayısını giriniz.");
            int m = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;


            for (int i = 0; i < number; i++)
            {

                Console.Write("{0}. sayıyı giriniz : ", i + 1);
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                
                if (girilenSayi >= 0)
                {
                    if (girilenSayi % 2 == 0)
                        toplam++;

                }else{
                    Console.WriteLine("Lütfen pozitif sayı giriniz.");
                    break;
                }


                

                Console.Write("{0}. sayıyı giriniz : ", i + 1);
                int girilenSayi2 = Convert.ToInt32(Console.ReadLine());
                
                if (girilenSayi2%m==0 || girilenSayi2==m)
                {
                    Console.WriteLine(girilenSayi2);
                }




            }


            Console.WriteLine("Toplam pozitif sayı : {0} ", toplam);
        }
    }
}
