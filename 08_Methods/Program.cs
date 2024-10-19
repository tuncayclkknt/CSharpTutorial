using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods

            /*
            CustomerList();

            void CustomerList()
            {
                Console.WriteLine("Zeynep");
                Console.WriteLine("Tuncay Çelikkanat");
                Console.WriteLine("Çuncay Telikkanat");
            }
            
            Sum();
            void Sum()
            {
                int x = 1, y = 2, z = x + y;
                Console.WriteLine(z);
            }
            */
            #endregion

            #region Void Methods With Paramethers
            /*
            WriteMethod("Tuncay");

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName + "!.");
            }

            void CustomerCard(string name, string surname)
            {
                Console.WriteLine($"Customer: {name} {surname}.");
            }

            CustomerCard("Zeynep", "Bayraktar");

            void Sum(int num1, int num2,int num3)
            {
                Console.WriteLine(num1 + num2 + num3);
            }
            Sum(5,6,7);
            */

            #endregion

            #region Non-Void Methods

            /*
            string CustomerName()
            {
                return "Zeynep Çelikkanat";
            }

            Console.WriteLine(CustomerName());

            string StudentCard()
            {
                string name = "Tuncay";
                string surname = "Çelikkanat";
                return name + surname;
            }

            Console.WriteLine(StudentCard());

            string CountryCard(string name, string capital, string flagColor)
            {
                string cardInfo = $"Country: {name} - Capital: {capital} - Flag Color: {flagColor}";
                return cardInfo;
            }

            string x, y, z;
            Console.Write("Enter country name, capital and flag color: ");
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            string ExamResult(string name,int ex1, int ex2, int ex3)
            {
                int result = (ex1 + ex2 + ex3) / 3;
                if (result >= 50)
                    return $"{name} passed with {result} point.";
                return $"{name} failed with {result} point.";
            }

            Console.WriteLine(ExamResult("Tuncay",14, 75,93));
            Console.WriteLine(ExamResult("Zeynep",43, 57,34));

            */

            #endregion

            Console.ReadKey();
        }
    }
}