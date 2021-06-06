using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******Atama İşlemleri********");
            int x = 5;
            int y = 2;

            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(y);
            x *= 2;


            Console.WriteLine("*******Mantıksal İşlemler********");

            bool isSuccess = true;
            bool isComplated = false;

            if (isSuccess && isComplated)
                Console.WriteLine("Perfect");

            if (isSuccess || isComplated)
                Console.WriteLine("Great");

            if (isSuccess && !isComplated)
                Console.WriteLine("Fine");

                        Console.WriteLine("*******İlişkisel Operatörler********");


            int a = 5;
            int b = 6;

            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a>b;

             Console.WriteLine(sonuc);
            sonuc = a>=b;

             Console.WriteLine(sonuc);
            sonuc = a<=b;

             Console.WriteLine(sonuc);
            sonuc = a==b;

             Console.WriteLine(sonuc);
            sonuc = a!=b;


            Console.WriteLine("*******Aritmetik Operatörler********");

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
