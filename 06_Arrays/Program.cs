using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region Basic Array Examples
            /*
            string[] colours = new string[3];
            colours[0] = "red";
            colours[1] = "green";
            colours[2] = "blue";

            Console.WriteLine(colours[2]);

            int[] number = new int[10];
            number[0] = 12;
            number[1] = 13;
            number[2] = 14;
            number[3] = 15;

            Console.WriteLine(number[7]);
            

            string[] cities = { "Prag", "Roma", "Kayseri" };
            Console.WriteLine(cities[2]);
            

            char[] symbols = new char[] {'%','&','(',')' };
            foreach (char c in symbols)
                Console.WriteLine(c);
            

            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(0,100);

            int maxNumber = myArray[0];

            foreach (int i in myArray)
                Console.Write($"{i} ");
            Console.WriteLine();
            

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                    maxNumber = myArray[i];
            }

            Console.WriteLine($"Max number: {maxNumber}");
            */

            #endregion

            #region Listing
            /*

            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber = random.Next(1,100);
                numbers[i] = randomNumber;
            }

            foreach (int num in numbers)
                if (num % 2 == 0) Console.WriteLine(num);
            */

            #endregion

            #region Array Methods
            /*
            string[] people = { "Zeynep", "Tuncay", "Sena", "Zehra", "Ali" };            
            
            Console.WriteLine(people.Length);
            
            Array.Sort(people); // sorting alp, numbers ...
            foreach (string person in people) Console.WriteLine(person);
            Console.WriteLine(new string('-', 15));

            Array.Reverse(people); // Reverse...
            foreach (string person in people) Console.WriteLine(person);
            
            Console.WriteLine(Array.IndexOf(people,"Zeynep"));
            Console.WriteLine(people.Max()); // for numbers it get max number on an array
            Console.WriteLine(people.Min()); // for numbers it get min number on an array
            */
            #endregion

            #region Getting inputs
            /*
            string[] cities = new string[4];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Please enter {i + 1}. city: ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine(new string('-',15));

            foreach (string i in cities) Console.WriteLine(i);
            

            int[] numbers = new int[10];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
                sum += numbers[i];
                Console.WriteLine($"Number[{i}]: {numbers[i],3} / " +
                    $"Sum: {sum,4}");
            }
            

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++) numbers[i] = random.Next(0,100);

            Console.WriteLine("Even Numbers: ");
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',20));

            Console.WriteLine("Odd Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    Console.Write($"{numbers[i]} ");
            }
            */

            #endregion

            Console.ReadKey();

        }
    }
}
