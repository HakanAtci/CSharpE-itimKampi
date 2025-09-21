using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //    double number;

            //    number = 4.87; //Kod ekranında . gözükmez virgül gözükür

            //    Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + " Tl ");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " Tl ");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " Tl ");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " Tl ");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " Tl ");

            //double appleGram, orangeGram, strawberryGram,potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.747;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates" + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine( );


            //Console.WriteLine("Aldığınız Ürünlerin Toplam Fiyatı: " + shoppingTotalPrice);



            #endregion

            #region Char Değişkenler 

            //Formatı tek tırnaktır 

            //Console.WriteLine();

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //ctrl + f kombinasyonu ile çoklu isim değiştirilebilir 

            //Console.WriteLine("****** CSharp Hava Yolları Yolcu Bilgisi ******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();




            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //ABC12D 

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoeCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoeCount*shoePrice + computerPrice*computerCount + chairPrice*chairCount + tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Aldığınız Ürünlerin Toplam Fiyatı: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınav Puanlarınızın Toplam Ortalaması: " + result);

            #endregion


            #region Klavyeden Karakter Gİrişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: " + gender);

            #endregion

            Console.Read();
        }
    }
}