using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else
            /*
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            if (password == "abcd") {
                Console.WriteLine("Login successfully.");
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
            */
            //-------------------------------------------------------
            /*
            string capital, country;
            Console.Write("Write the capital: ");
            capital = Console.ReadLine();

            Console.Write("Write the country: ");
            country = Console.ReadLine();

            if (capital.ToLower() == "ankara" & country.ToLower() == "türkiye")
            {
                Console.WriteLine("Right info");
            }
            else { Console.WriteLine("Wrong info"); }
            */
            //-------------------------------------------------------
            /*
            int number;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("True number.");
            }
            else
            {
                Console.WriteLine("False number.");
            }
            */
            //-------------------------------------------------------

            /*
            int exam1, exam2, exam3, avarage;
            string result = "error";

            Console.Write("Exam 1: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Exam 2: ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Exam 3: ");
            exam3 = int.Parse(Console.ReadLine());

            avarage = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Avarage: " + avarage);

            if (avarage > 0 & avarage <= 50)
                result = "Vasat";
            else if (avarage > 50 & avarage <= 70)
                result = "Middle";
            else if (avarage > 70 & avarage <= 85)
                result = "Good";
            else if(avarage > 84)
                result = "Pörfekkt player.";

            Console.WriteLine(result);
            */

            /*
            string city;
            Console.Write("Please enter a city name: ");
            city = Console.ReadLine();

            if (city == "kayseri" | city == "ankara" | city == "van")
                Console.WriteLine("City is found.");
            else
                Console.WriteLine("City is not found.");
            */

            /*
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();

            if (username != "admin") 
                Console.WriteLine("This username cannot acceptable!");
            else
                Console.WriteLine("Welcome");
            */

            #endregion

            #region Mod Operation

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            /*
            Console.Write("Plase enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;
            Console.WriteLine($"{number1} % {number2} = {result}");
            */

            /*
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("This number is an even number.");
            else
                Console.WriteLine("This number is an odd number.");
            */
            #endregion

            #region If else with Chars
            /*
            char team;
            Console.Write("Please enter your team symbol: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
                Console.WriteLine("Galatasaray");
            else if (team == 'f' | team == 'F')
                Console.WriteLine("Fenerbahçe");
            */



            #endregion

            #region Example App
            /*
            Console.WriteLine("***** Bayraktar Restourant *****");
            Console.WriteLine();
            Console.WriteLine(new string('-',25));
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- İçecekler");
            Console.WriteLine("4- Tatlılar");
            Console.WriteLine(new string('-', 25));

            string menuItem;
            Console.Write("Select a menu: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 12) + " Ana Yemekler " + new string('-', 12));
                Console.WriteLine();
                Console.WriteLine(
                    "1- Meatball\n" +
                    "2- FlayingNoodle\n" +
                    "3- Fried Somon\n" +
                    "4- Buffle");
            }
            else if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 12) + " Çorbalar " + new string('-', 12));
                Console.WriteLine();
                Console.WriteLine(
                    "1- Mercimek Çorbası\n" +
                    "2- Ezogelin Çorba\n" +
                    "3- Domates Çorba");
            }
            else if(menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 12) + " İçecekler " + new string('-', 12));
                Console.WriteLine();
                Console.WriteLine(
                    "1- Çay\n" +
                    "2- Coffee\n" +
                    "3- Somotie\n" +
                    "4- Milkshake");
            }
            else if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 12) + " Tatlılar " + new string('-', 12));
                Console.WriteLine();
                Console.WriteLine(
                    "1- Baklava\n" +
                    "2- Ben\n" +
                    "3- Kazandibi\n" +
                    "4- Trieliçe");
            }
            */
            #endregion

            #region Switch Case
            /*
            Console.Write("Enter a month number: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("Jun"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("Augast"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Wrong number."); break;
            }
            */
            #endregion

            #region Switch Case Calculator
            /*
            double number1, number2, result;
            char symbol;

            Console.Write("Write first number: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("Write second number: ");
            number2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operation(+, -, /, *): ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': 
                    result = number1 + number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Result: " + result);
                    break;
                default: Console.WriteLine("Invalid enter"); break;

            }
            */
            #endregion

            Console.Read();

        }
    }
}
