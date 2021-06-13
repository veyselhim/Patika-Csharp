using System;

namespace Odev1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet kelime gireceksiniz ? : ");
            int wordNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < wordNumber; i++)
            {

                Console.WriteLine("{0}. kelimeyi giriniz : ", i);
                string word = Console.ReadLine();

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    Console.Write(word[j]);
                }

            }
        }
    }
}
