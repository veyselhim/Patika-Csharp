using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger;
            deger = 2;

            string degisken = null;
            Console.WriteLine(deger);
            
            byte b = 5;  // 1 byte
            sbyte c = 5;

            //ushort u = 5;   //2 byte

            Int16 i16= 2;   //2 byte
            int i = 2;  // 4 byte
            Int32 i32 = 2;  // 4 
            Int64 i64 = 8;   // 8byte        

            uint  ui= 2;  //4 byte
            long l = 3; //8 byte
            ulong ul = 4;  //8 byte

            // Reel sayılar
            float f = 4; //4 byte 
            double d = 5;  // 8 byte
            decimal de = 5;  //16 byte

            char ch = 'A';  // 2 byte
            string str = "veysel"; //sınırsız
            
            bool isB = true;

            DateTime dt = DateTime.Now; 

            Console.WriteLine(dt);

            object o1 = "x";
            object o3 = 4;
            object o4 = 4.3;

            string str1 = String.Empty;
            str1 ="Veysel";
            string ad = "Veysel";
            string soyad = "Him";
            string tamAdSoyad = ad + " " + soyad;
            
            int integer1 = 5;
            int integer2 = 4;
            int integer3 = integer1*integer2;

            bool b1 = 10<2;

            //Degisken Dönüşümleri

            string str10 = "10";
            int int20 = 20;

            string yeniDeger = str10 + int20.ToString();

            Console.WriteLine(yeniDeger);

            int int11 = int20 + Convert.ToInt32(str10);
            Console.WriteLine(int11);

            int int22  = int20 + int.Parse(str10);

            string dateTime  = DateTime.Now.ToString("dd.MM.yyyy");


        }

    }
}
