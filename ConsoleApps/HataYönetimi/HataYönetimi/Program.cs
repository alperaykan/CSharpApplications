using System;

namespace HataYönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TryCatchBlokFarklıExceptionYönetimi
            //// Hata yönetimi için try-catch blokları kullanılır.

            //try
            //{
            //    Console.WriteLine("İlk Sayıyı giriniz");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    int toplam = number1 + number2;
            //    Console.WriteLine("İki sayının toplamı  " + toplam);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Yanlış formatta girdiniz. Litfen sonraki denemede sayı giriniz.");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Yanlış formatta girdiniz. Litfen sonraki denemede sayı giriniz.");
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            #endregion

            #region TryCatchExceptionMessage
            //// Hata yönetimi için try-catch blokları kullanılır.

            //try
            //{
            //    Console.WriteLine("İlk Sayıyı giriniz");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    int toplam = number1 + number2;
            //    Console.WriteLine("İki sayının toplamı  " + toplam);
            //}
            //// Burada exception ex adında bir objeye dönüşüyor ve ex objesi içindeki işlemleri görebilir okuyabiliriz.
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region TryCatchFinally
            //// Hata yönetimi için try-catch blokları kullanılır.

            try
            {
                Console.WriteLine("İlk Sayıyı giriniz");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int toplam = number1 + number2;
                Console.WriteLine("İki sayının toplamı  " + toplam);
            }
            // Burada exception ex adında bir objeye dönüşüyor ve ex objesi içindeki işlemleri görebilir okuyabiliriz.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Exception a girsin yada girmesin finally komutu çalışır.
            finally
            {
                Console.WriteLine("Sonuna geldin");
            }

            #endregion
        }
    }
}
