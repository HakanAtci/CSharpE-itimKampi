using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creating 10 stars under each other //Birbirinin altında 10 yıldız yaratmak

            //for (int i = 1 ; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Creating 10 stars side by side

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*"); // Eğer ki line komutunu kullanmazsak yan yana oluşturur
            //}

            #endregion

            #region Create 10 stars one below the other, but have 10 stars in each row

            //for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine("*********");
            //    }

            #endregion

            #region Right Triangle

            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion

            Console.Read();
        }
    }
}
