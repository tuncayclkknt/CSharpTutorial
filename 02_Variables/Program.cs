using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Variables
            /*
            Console.WriteLine("***** Price List *****");
            Console.WriteLine();

            double applePrice, orangePrice, patatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            patatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine($"Price of an apple   = {applePrice,-4}");
            Console.WriteLine($"Price of an orange  = {orangePrice,-4}");
            Console.WriteLine($"Price of a patato   = {patatoPrice,-4}");
            Console.WriteLine($"Price of a tomato   = {tomatoPrice,-4}");
            Console.WriteLine();

            double appleGram, orangeGram, patatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 3.579;
            patatoGram = 0.567;
            tomatoGram = 5.786;

            Console.WriteLine($"Product: Apple\nPrice of one: {applePrice}\nGram: {appleGram}\n" +
                $"Total Price: {appleGram*applePrice}\n");
            Console.WriteLine($"Product: Orange\nPrice of one: {orangePrice}\nGram: {orangeGram}\n" +
                $"Total Price: {orangeGram*orangePrice}\n");
            Console.WriteLine($"Product: Patato\nPrice of one: {patatoPrice}\nGram: {patatoGram}\n" +
                $"Total Price: {patatoGram*patatoPrice}\n");
            Console.WriteLine($"Product: Tomato\nPrice of one: {tomatoPrice}\nGram: {patatoGram}\n" +
                $"Total Price: {patatoGram *patatoPrice}\n");
            */
            #endregion

            #region Char Variable
            /*
            char symbol = 'a';
            Console.WriteLine(symbol);
            */
            #endregion

            #region String Inputs
            /*
            Console.WriteLine("**** THY passenger Info ****");
            Console.WriteLine();
            string passengerName, passengerSurname, passengerDistrict, 
                passengerCity, passengerAge, passengerID;

            Console.Write("Passenger name: ");
            passengerName = Console.ReadLine();

            Console.Write("Passenger surname: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Passenger disctrict: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Passenger city: ");
            passengerCity = Console.ReadLine();

            Console.Write("Passenger age: ");
            passengerAge = Console.ReadLine();

            Console.Write("Passenger ID: ");
            passengerID = Console.ReadLine();

            Console.WriteLine(new string('-',25));
            Console.WriteLine($"Passenger: {passengerName} {passengerSurname}.\n" +
                $"ID: {passengerID}\n" +
                $"Address: {passengerDistrict}/{passengerCity}");
            */
            #endregion

            #region Int Inputs
            /*
            int shoePrice = 1000, 
                computerPrice = 20000, 
                chairPrice = 5000, 
                tvPrice = 12000;

            int shoeCount,
                computerCount,
                chairCount,
                tvCount;

            Console.Write("Write the number of the shoes you buy: ");
            shoeCount = int.Parse( Console.ReadLine() );

            Console.Write("Write the number of the computers you buy: ");
            computerCount = int.Parse( Console.ReadLine() );
            
            Console.Write("Write the number of the chairs you buy: ");
            chairCount = int.Parse( Console.ReadLine() );
            
            Console.Write("Write the number of the TVs you buy: ");
            tvCount = int.Parse( Console.ReadLine() );

            int totalPrice = shoeCount * shoePrice +
                computerCount * computerPrice + chairCount * chairPrice +
                tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine($"Total price: {totalPrice}");
            */
            #endregion

            #region Double Inputs
            /*
            double exam1, exam2, exam3, result;

            Console.Write("Please enter your first exam point: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter your second exam point: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter your third exam point: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine($"Average: {result}");
            */
            #endregion

            #region Char Inputs
            /*
            char gender;
            Console.Write("Select a sex: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine($"Gender you selected: {gender}");
            */
            #endregion

            Console.ReadKey();

        }
    }
}