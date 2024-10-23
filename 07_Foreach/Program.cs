using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach
            /*
            string[] cities = { "Ankara", "Kayseri","İstanbul", "Yozgat" };
            int[] numbers = {12,43,64,34,2,75,87,98,09};

            Console.WriteLine("Cities: ");
            foreach (string city in cities)
                Console.Write($"{city} ");

            Console.WriteLine("\nNumbers: ");
            foreach (int number in numbers)
                Console.Write($"{number} ");

            Console.WriteLine("\nNumber that divibable with 2 unremaining: ");
            foreach (int number in numbers)
            {
                if (number % 2 == 0) Console.Write($"{number} ");
            }

            int total = 0;
            foreach(int i in numbers)
                total += i;
            Console.WriteLine($"\nTotal: {total}");
            

            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,0
            };

            foreach (int i in numbers)
                Console.Write($"{i} ");
            Console.WriteLine();
            

            string word = "Tuncay";

            foreach (char c in word)
                Console.WriteLine(c);
            */

            #endregion

            #region Example Exam System App
            
            Console.WriteLine("***** C# *****"); 
            Console.WriteLine("");

            Console.WriteLine(new string('-', 25));
            int studentCount = 0;

            while (studentCount <= 0)

            {
                Console.Write("How many people are there in your class: ");
                try
                {
                    studentCount = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine(new string('-', 25));
                }
            }       
            
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. student name: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResut = 0;
                double value = 0;

                for (int j = 0; j < 3; j++)
                {
                    bool isValid = false;

                    while (!isValid)
                    {
                        Console.Write($"Enter {j + 1}. exam note for {studentNames[i]}: ");
                        try
                        {
                            value = double.Parse(Console.ReadLine());
                            totalExamResut += value;
                            isValid = true;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message); ;
                        }
                    }                    
                }
                Console.WriteLine(new string('-', 20));

                studentExamAvg[i] = totalExamResut / 3;
             }
            Console.WriteLine();
            Console.WriteLine(new string('-', 25));

            for (int i = 0; i < studentCount; i++) {
                Console.WriteLine($"{studentNames[i]} has avarage: {studentExamAvg[i]:0.##}");
                if (studentExamAvg[i] >= 50)
                    Console.WriteLine($"{studentNames[i]} passed the course.");
                else
                    Console.WriteLine($"{studentNames[i]} failed the course.");
                Console.WriteLine(new string('-',25));
            }
            
            #endregion

            Console.ReadLine();

        }
    }
}
