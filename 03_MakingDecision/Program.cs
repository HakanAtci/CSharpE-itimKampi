using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İf Else

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
            //    Console.Write("Veriler Yanlış");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav 1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average > 84)
            //{
            //    result = "Çok İyi";
            //}
            //else
            //{
            //    result = "Bir Daha Not Giriniz";
            //}

            //    Console.WriteLine(result); //Burada resulta bir değer verilmez ise ya da else ile kapatılmazsa kod çalışmaz 

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city= Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if(username != "admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            #endregion

            #region Mode operations

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Please enter the first number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("the remainder of dividing the first number by the second number: " + result);

            //Console.Write("Please enter the number: ");
            //int number =int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Your Number is a even");//sayınız tektir
            //}
            //else
            //{
            //    Console.Write("Your Number is a unique");
            //}

            #endregion

            #region Decision structures with char variables //Char Değişkenleri İle Karar Yapıları
            //char team;
            //Console.Write("Please enter the team symbol: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team =='F' )
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Sample project application

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Main Courses");
            //Console.WriteLine("2-Soups");
            //Console.WriteLine("3-Pizzas");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("5-Deserts");
            //Console.WriteLine("---------------------------------------");

            //string menuItem;

            //Console.Write("Please select the menu number you want to see the details of: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Main Courses ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Chicken with curry sauce");
            //    Console.WriteLine("2-Friying plate ");
            //    Console.WriteLine("3-Bean and Rice");
            //    Console.WriteLine("4-Baked somon ");
            //    Console.WriteLine("5-Eggplant moussaka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Main Courses ----------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Soups ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Lentil");//mercimek
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Soups ----------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzas ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mediterranean pizza");
            //    Console.WriteLine("2-Margaritha pizza");
            //    Console.WriteLine("2-Chicken pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzas ----------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Drinks ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Coke");
            //    Console.WriteLine("2-Lemonade");
            //    Console.WriteLine("2-Water");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Drinks ----------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Deserts ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-triliche");
            //    Console.WriteLine("2-cheseecake");
            //    Console.WriteLine("2-eclair");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Deserts ----------");
            //}

            #endregion

            #region Switch Case 


            //Console.Write("Please enter your month: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;

            //}

            #endregion

            #region Calculator with switch case

            //int number1, number2, result;
            //char symbol;

            //Console.Write("enter the first number: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("enter the second number: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the transaction you want to perform: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //            result = number1 + number2;
            //            Console.WriteLine("Total: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("subtraction: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("multiplication: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("divide: " + result);
            //        break;
            //}


            #endregion

            Console.Read();
        }
    }
}
