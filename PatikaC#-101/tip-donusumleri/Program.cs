using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz dönüşüm)

            byte a = 5;

            byte b = 20;

            byte c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " + d);

            long e = d;
            Console.WriteLine("e : " + e);

            float i = e;
            Console.WriteLine("i : " + i);

            string str = "veysel";
            char f = 'k';
            object g = str + f + d;
            Console.WriteLine("g : " + g);


            //Explicit Con. (Bilinçli dön.) 


             Console.WriteLine("***** Explicit Conversion *******");
             int x = 4;
             byte y = (byte)x;
             Console.WriteLine("y : " + y);

             int v = 100;
             byte t = (byte)v;
            Console.WriteLine("t : " + t);

            float w = 10.3f;
            byte z = (byte)w;
            Console.WriteLine("z : " + z);


            // **** To String ****

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz);

            //System.Convert
            
            string s1 = "10" , s2 ="20";    

            int sayi1 , sayi2;

            int toplam;
            
            sayi1 = Convert.ToInt32(s1);

            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);


            //Parse

            ParseMethod();
        }

        public static void ParseMethod(){

            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);

            
        }
    }
}
