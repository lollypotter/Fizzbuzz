using System;

namespace Fizzbuzz
{
    class Program
    {
        static string Fizz(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            return "";
        }

        static string Buzz(int num)
        {
            if (num % 5 == 0)
            {
                return "Buzz";
            }
            return "";
        }

        static void Main(string[] args)
        {
            for (var i = 1; i < 101; i++)
            {
                var myString = "";
                myString += Fizz(i);
                myString += Buzz(i);
                Console.WriteLine(myString == "" ? i : myString);
            }
        }
    }
}