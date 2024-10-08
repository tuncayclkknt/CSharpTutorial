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

            #region For
            /*
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Write this line 5 times.");

            for (int i = 0;i <= 20; i++)
                Console.Write(i + " ");

            Console.WriteLine();
            for (int i = 0; i <= 50; i+= 3)
                Console.Write(i + " ");
            

            Console.Write("Please enter a number: ");
            int finishValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < finishValue; i++)
                Console.WriteLine("Yaşasın Cumhuriyet!");
            */

            #endregion

            #region Desicion Structure with For Loop
            /*
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
            
            int sum = 0;

            for (int i = 0; i <= 10; i++)
                sum += i;
            Console.WriteLine(sum);
            
            
            int sum = 0;

            for (int i = 0; i < 20; i++)
            { 
                if (i % 2 == 0)
                    sum+= i;
            }

            Console.WriteLine(sum);
            

            int count = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                    count++;
            }
            Console.WriteLine(count);

            int bacterium = 1;
            for (int i = 0; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine($"{i,2} hours later: {bacterium}");
            }
            */
            #endregion

            #region While
            int i = 1;

            /*
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            while (i <= 10)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
                i++;

            }
            
            int sum = 0;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            */

            #endregion

            #region Example Quest
            //write the code that calculate the sum of digits of entered 3 digit number
            /*
            Console.Write("Please enter the 3 digit number: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds, sum;

            ones = number % 10;
            tens = (number / 10) % 10;
            hundreds = (number / 100);

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            Console.WriteLine("Sum: " + (ones + tens + hundreds));
            */
            #endregion

            Console.ReadKey();
        }
    }
}
