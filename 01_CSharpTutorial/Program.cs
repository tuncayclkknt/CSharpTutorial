using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region display methods
            /*
            Console.WriteLine("Hello World");

            Console.WriteLine("***** Food Catagories *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana yemek");
            Console.WriteLine("3-Tatlı");
            Console.WriteLine();
            Console.WriteLine("***** Food Catagories *****");
            */
            #endregion

            #region string variables
            /*
            //string
            string name = "Tuncay";
            string userSurname = "Çelikkanat";
            string userPhone = "123456";
            string userEmail = "tuncayclkknt@gmail.com";
            string userDistrict = "Yahyalı";


            Console.WriteLine("**** Reservation ****");
            Console.WriteLine(new String('-',25));
            Console.WriteLine($"Customer: {name}\n" +
                $"Phone: {userPhone}\n" +
                $"Email: {userEmail}\n" +
                $"Address: {userDistrict}\n");
            Console.WriteLine(new String('-', 25));
            */
            #endregion

            #region int variables
            /*
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine(
                $"Hamburger : {hamburgerPrice,5} TL \n" +
                $"Coke      : {cokePrice,5} TL \n" +
                $"Water     : {waterPrice,5} TL \n" +
                $"Fries     : {friesPrice,5} TL \n" +
                $"Pizza     : {pizzaPrice,5} TL \n" +
                $"Lemonade  : {lemonadePrice,5} TL \n");

            Console.WriteLine();
            int totalPrice = 0;

            int hamburgerCount = 3, 
                cokeCount = 3, 
                waterCount = 3, 
                friesCount = 1, 
                pizzaCount = 0, 
                lemonadeCount = 0;

            totalPrice += hamburgerPrice*hamburgerCount + cokePrice*cokeCount + waterPrice*waterCount
                + friesPrice*friesCount + pizzaCount*pizzaPrice + lemonadeCount*lemonadePrice;

            Console.WriteLine("You eat:");
            Console.WriteLine($"{hamburgerCount} hamburger(s), {cokeCount} coke(s), {waterCount} water(s),\n" +
                $"{friesCount} fries(es), {pizzaCount} pizza(s), {lemonadeCount} lemonade(s).");

            Console.WriteLine("Total: {0} TL",totalPrice);
            */
            #endregion

            Console.ReadLine();
        }
    }
}

/*
 * Print
 */
