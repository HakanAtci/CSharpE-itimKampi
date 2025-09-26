using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loops
            //Loops 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21 kod bunu yapar.

            // For(x;y;z) 
            // x: start value
            // y: end value 
            // z:increase decrease artış veya azalış

            //int i;

            //for (i = 1 ; i <= 5 ; i++)
            //{
            //    Console.WriteLine("C# Educations Camp");
            //}

            //for (int i = 1; i<=20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i<=50; i+=3)   // += i nin üzerine 3 ekleyerek git
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Girin: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 0; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //} 

            #endregion

            #region Decision structures with For loops

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i = 1; i <= 10 ; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;

            //for(int i = 1 ; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalvalue);

            //int count = 0; //7 ye bölünen 50 ye kadar olan kaç sayı var

            //for (int i = 1; i < 50 ; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Bakteri örneği 1-2-4-8-16

            //int bacterium = 1;
            //for (int i = 1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + "Saat Sonunda: " + bacterium);
            //}
            #endregion

            #region While Loops 

            //While(Şart)
            //{
            //transactions//işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Loops");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);



            #endregion

            #region Example Quiz Question
            //Program that calculates the sum of the digits of a 3-digit 
            //number entered from the keyboard

            //456 
            //Console.Write("Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int  ones , tens , hundred;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundred = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundred);

            //sum = ones + tens + hundred;

            //Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
