using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Prework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "miro";
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine($"Hi {name} !" );
            Console.WriteLine($"Hi {name.ToUpper()} !");

            var names = new[] { "Anna", "Miro", "Zenon" };
            foreach (var item in names)
            {
                Console.WriteLine($"hello {item.ToLower()} ! ");
            }

            string firstFriend = "Miro";
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters. ");

            string greetings = "    Hello   ";
            Console.WriteLine($"[{greetings}]");
            Console.WriteLine($"[{greetings.TrimStart()}]");
            Console.WriteLine($"[{greetings.TrimEnd()}]");
            Console.WriteLine($"[{greetings.Trim()}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Hi");
            Console.WriteLine(sayHello);

            Console.WriteLine($"string \"{sayHello}\" contains Hi: " + sayHello.Contains("Hi"));
            Console.WriteLine($"string \"{sayHello}\" starts with Hi: " + sayHello.StartsWith("Hi"));
            Console.WriteLine($"string \"{sayHello}\" ends with bye: " + sayHello.EndsWith("bye"));

            int a = 8;
            int b = 2;
            int sum = a + b;
            Console.WriteLine(sum);
            int substraction = a - b;
            Console.WriteLine(substraction);
            int multiplication = a * b;
            Console.WriteLine(multiplication);
            int division = a / b;
            Console.WriteLine(division);

            Console.WriteLine($" the range of integers is from {int.MinValue} to {int.MaxValue}");

            Console.WriteLine($" remainder (modulo) 3%2 is: {3 % 2}");

            Console.WriteLine($" the range of double is from {double.MinValue} to {double.MaxValue}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            //decimal type has a smaller range but greater precision than double

            Console.WriteLine($" the range of decimal is from {decimal.MinValue} to {decimal.MaxValue}");
            decimal c = 1.0M; //M for decimal
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            Radius(2.5);

            int x = 10;
            int y = 11;
            if(x + y > 20 && x != b)
            {
                Console.WriteLine($"sum of {x} and {y} is greater than 20");
                Console.WriteLine($"{x} is not equal {y}");
            }
            else
            {
                Console.WriteLine($"sum of {x} and {y} is not greater than 20");
            }

            if (x + y < 20 || x != b)
            {
                Console.WriteLine($"sum of {x} and {y} is smaller than 20 or {x} is not equal {y}");
            }

            Loops(); //Use loops to repeat operations

            NestedLoops(); //nested loops

            Remainder(); //modulo

            ListByForeach(); //

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

        private static void Radius(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
