using System;
using System.Collections.Generic;

namespace Prework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            Loops(); //Use loops to repeat operations
            
            NestedLoops(); //nested loops

            Remainder(); //modulo

            ListByForeach();

            SearchList("miro");
            SearchList("jan");
            SortList();
            FibonacciNumbers();

        }

        private static void Loops()
        {
            int counter = 10;
            while (counter > 0) //test before
            {
                Console.WriteLine($"counter is : {counter}");
                counter--;
            }

            do
            {
                Console.WriteLine($"counter is : {counter}");
                counter++;
            } while (counter < 10); //check after

            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"iterator is : {i}");
            }
        }

        private static void NestedLoops()
        {
            for (int row = 0; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"the cell is : ({row}, {column})");
                }
            }
        }

        private static void Remainder()
        {
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {                
                if(i % 3 == 0)
                {
                    sum += i;
                }                
            }
            Console.WriteLine($"the sum of all integers from 1 to 20 and divisible by 3 is {sum}");
        }

        private static void ListByForeach()
        {
            var names = new List<string> { "miro", "ania", "filip" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hi {char.ToUpper(name[0])}{name.Substring(1)}"); //make first letter upper
            }

            names.Add("zenon");
            names.Remove("miro");
            foreach (var name in names)
            {
                Console.WriteLine($"Hi {name}");
            }

            Console.WriteLine($"first name on the list is: {names[0]}");
            Console.WriteLine($"number of names on the list: {names.Count}");
        }

        private static void SearchList(string name)
        {
            var names = new List<string> { "miro", "ania", "filip" };
            var index = names.IndexOf(name);
            if(index == -1)
            {
                Console.WriteLine($"can't find the name \"{name}\" on the list");               
            }
            else
            {
                Console.WriteLine($"{name} is on index : {index}");
            }           
        }

        private static void SortList()
        {
            var names = new List<string> { "miro", "ania", "filip" };
            Console.WriteLine("before sort method");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("after sort method");

            names.Sort(); //sort list
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }

        private static void FibonacciNumbers()
        {
            var fibonacciNumbers = new List<int> { 0, 1, 1 };

            while(fibonacciNumbers.Count <= 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            Console.WriteLine("first 20 fibonacci Numbers:");
            foreach(var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
