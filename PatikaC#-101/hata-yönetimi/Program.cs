using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }

            try
            {
                // int a  = int.Parse("test");
                int a = int.Parse("-22222222222");

             }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Veri boş girilemez" + ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil." + ex);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük yada çok küçük değer girdiniz." + ex);
            }finally{
                Console.WriteLine("İşlem tamamlandı.");
            }

        }
    }
}
