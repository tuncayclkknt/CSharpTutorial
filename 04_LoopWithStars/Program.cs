using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 10 Stars Below
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            */
            #endregion

            #region 10 Stars Side by Side
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
            */
            #endregion

            #region Right Triangle
            /*
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Inverted Right Triangle
            /*
            for (int i = 10 ; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Right and Inverted Right Triangle
            /*
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Baklava
            /*
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1;j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i = n- 1;i >= 1; i--)
            {
                for(int j = n - 1; j > 0; j--)
                    Console.Write(" ");
                
                for ( int k = 1; k <= 2 * i - 1;k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            */
            #endregion

            #region Pyramid
            /*
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                    Console.Write(" ");

                for (int k = 1; k <= 2 * i -1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            */
            #endregion

            #region Inversed Pyramid
            /*
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                    Console.Write(" ");

                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            */
            #endregion

            Console.ReadKey();
        }
    }
}
