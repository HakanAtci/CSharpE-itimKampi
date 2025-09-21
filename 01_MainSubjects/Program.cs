using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects //Proje ismi
{
    internal class Program //class sınıftır internal erişim belirleyici
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam"); //Line imleci alt satıra kaydırır 

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion


            #region String Değişkenler

            //String
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Hakan";
            //Console.Write(name);,

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "0544 550 36 09";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: "+ customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname="Ozturk";
            //customerPhone = "0555 605 9040";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");



            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("------Kola: " + cokePrice + "Tl");
            Console.WriteLine("------Limonata: " + lemonadePrice +  "TL");
            Console.WriteLine("------Su: " + waterPrice + "Tl");
            Console.WriteLine("------Kızarmış Patates: " + friesPrice + "Tl");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount; 
            int pizzaCount; 
            int lemonadeCount;  

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            
            hamburgerCount = 3;
            cokeCount = 3;  
            waterCount = 3; 
            friesCount = 3;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Hamburger Tutarı: "  + totalHamburgerPrice + "Tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "Tl");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "Tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "Tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "Tl");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "Tl");

            Console.WriteLine();
            int totalPrice=totalCokePrice+totalFriesPrice+totalLemonadePrice+totalHamburgerPrice+totalWaterPrice+totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "Tl");


            #endregion
            Console.Read(); //Entere basana kadar kodu okutur

        }
    }
}




//Yazdırma Komutları 