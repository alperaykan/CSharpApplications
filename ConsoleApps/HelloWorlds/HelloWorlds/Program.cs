using System;

namespace HelloWorlds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Başlangıç

            //Console.WriteLine("Hello World!");

            //int j = 10;

            //for(int i= 0; i < j; i++)
            //{
            //   Console.Write(i);
            //   Console.WriteLine("Selamın aleyküm");
            //   Console.ReadKey(); Bu herhangi bir tuşla read işlemi yapıyor.
            //   Console.Read();    Bu sadece enter tuşuyla read işlemi yapıyor.
            //}

            #endregion

            #region   İsimSoyisimAlıştırması

            //Console.Write("İsminiz ne?  =>  ");
            //var ad = Console.ReadLine();
            //Console.Write("Soyadınız ne?  =>  ");
            //var soyad = Console.ReadLine();
            //Console.WriteLine("İyi Günler!!  " + ad +" "+ soyad);

            #endregion

            #region YaşMeslekAlıştırması

            //Console.WriteLine("Kaç Yaşındasınız?  ");
            //Console.ReadLine();
            //Console.Write("Mesleğiniz??");
            //Console.ReadLine();
            //Console.WriteLine("Herhangi bir tuşa basarak uygulamayı sonlandırabilirsinz. İyi Günler!!");
            //Console.ReadKey();

            #endregion

            #region MeyveTatlıAlıştırması

            //Console.WriteLine("En sevdiğin meyve hangisi ? ");
            //string meyve = Console.ReadLine();
            //Console.WriteLine("En sevdiğin tatlı hangisi ? ");
            //string tatlı = Console.ReadLine();
            //Console.WriteLine("Dur tahmin ediyim. En sevdiğin tatlı " + tatlı);
            //Console.WriteLine("En sevdiğin meyve de " + meyve);

            #endregion

            #region Değişkenler

            //int ilkSayi;
            //int ikinciSayi;
            //int ücüncüSayi;

            //string nameSpace;
            //string surnameSpace;
            //string jobSpace;

            #endregion

            #region Operatörler
            // + - * / %

            // % => mod, bir sayının başka bir sayıya bölümünden kalanı temsil eder.
            //int number = 7 % 2;
            // diğer operatörler aynı zaten
            //Console.WriteLine(number);
            #endregion

            #region MantıksalOperatörler
            // '==', '<', '>', '<=', '>='

            // '==' ifadesi denklik ifade eder true yada false döndürür
            //Console.WriteLine("5 ile 7 eşit midir???");
            //Console.WriteLine(5 == 7);

            #endregion

            #region SayıTahminEtmeceAlıştırması

            //string secretNumber = "18";
            //string number;

            //Console.WriteLine("Sayıyı tahmin edebilecek misin bakalım??");

            //number = Console.ReadLine();

            //bool control = secretNumber == number;

            //Console.WriteLine(control);

            //if(control == false)
            //{
            //    Console.WriteLine("Bilemedin. Tekrar dene");
            //    number = Console.ReadLine();
            //}
            //else { Console.WriteLine("Tebrikler. Bildin!!!"); }

            #endregion

            #region Ve-VeyaOperatörleri

            //int x = 55;

            //bool control = (x > 50 && x < 60) && (x % 5 == 0 || x % 3 == 0);

            //Console.WriteLine(control);

            #endregion

            #region

            string kullaniciAdi = "Pappagu";
            string eMail = "alperaykan@gmail.com";
            string password = "123456";

            Console.WriteLine("Kullanıcı adınız?");
            string kullaniciAdiGiris = Console.ReadLine();
            bool controlKullanici = (kullaniciAdi == kullaniciAdiGiris);
            if (controlKullanici)
            {
                Console.WriteLine("Email Adresiniz?");
                string eMailGiris = Console.ReadLine();
                bool controlEmail = (eMail == eMailGiris);
                if (controlEmail)
                {
                    Console.WriteLine("Şifreniz?");
                    string passwordGiris = Console.ReadLine();
                    bool controlPassword = (password == passwordGiris);
                    if (controlPassword)
                    {
                        Console.WriteLine("Tebrikler. Giriş Başarılı !!!!");
                    }
                    else
                    {
                        Console.WriteLine("Şifreniz yanlış");
                    }
                }
                else
                {
                    Console.WriteLine("Emailiniz yanlış");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı Adınız yanlış");
            }

            #endregion

        }
    }
}
