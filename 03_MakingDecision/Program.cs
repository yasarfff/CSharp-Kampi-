using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            // Karar yapıları birden fazla şartla yazılabilir: 

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgiler");
            //}


            //aritmetik değerlerle karar yapıları:



            // Birden fazla if kullanımı:
            // Sınav sonucu değerlendirme:

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1. Sınav Notunuzu Girin: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notunuzu Girin: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notunuzu Girin: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortlaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Fezahat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Fezahat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            // if ve else veya  | kullanımı:
            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city== "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            // eşit olmama != durum sorgusu:
            //string username;
            //Console.WriteLine("Lütfen Kullanıcı Adı Giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının, 2. sayıya bölümünden kalan: " + result);

            // Mod İle sayının tek çift olma durumunu sorgulama:
            //Console.Write("Lütfen Sayıyı Girin: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            // Takım bulma örneği:

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Girin: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulması

            Console.ReadKey();

        }
    }
}

// Karar Yapıları: Çıktı sonucuna göre programı yönlendirdiğimiz yapılarda kullanırız.
// Karar yapılarından sonra noktalı virgül konulmaz. Süslü parantez açılır.
// Ctrl + k + d kodları düzenler.
// mod sembolü programlamada % ile ifade edilir.