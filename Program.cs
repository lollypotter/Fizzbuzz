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
        
        static string Bang (int num)
        {
            if (num % 7 == 0)
            {
                return "Bang";
            }
            return "";
        }
        
        static string Bong (int num, string myString)
        {
            if (num % 11 == 0)
            {
                return "Bong";
            }
            return myString;
        }
        
        static string Fezz (int num, string myString)
        {
            if (num % 13 == 0 && myString == "")
            {
                myString = "Fezz";
                return myString;
            }

            if (num % 13 == 0 && myString != "")
            {
                int index = myString.IndexOf('B');

                if (index > -1)
                {
                    string insertedString = myString.Insert(index, "Fezz");
                    return insertedString;
                }

                string addedString = myString += "Fezz";
                return addedString;
            }
            return myString;
        }
        
        static string Reverse (int num, string myString)
        {
            if (num % 17 == 0)
            {
                
                return "Bong";
            }
            return myString;
        }

        static void Main(string[] args)
        {
            for (var i = 1; i < 175; i++)
            {
                var myString = "";
                myString += Fizz(i);
                myString += Buzz(i);
                myString += Bang(i);
                myString = Bong(i, myString);
                myString = Fezz(i, myString);
                myString = Reverse(i, myString);

                Console.WriteLine(myString == "" ? i : myString);
            }
        }
    }
}