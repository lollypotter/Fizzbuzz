using System;
using System.Collections.Generic;
using System.Linq;

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

        static string Bang(int num)
        {
            if (num % 7 == 0)
            {
                return "Bang";
            }

            return "";
        }

        static string Bong(int num, string myString)
        {
            if (num % 11 == 0)
            {
                return "Bong";
            }

            return myString;
        }

        static string Fezz(int num, string myString)
        {
            if (num % 13 == 0 && myString == "")
            {
                myString = "Fezz";
                return myString;
            }

            if (num % 13 == 0 && myString != "")
            {
                var insertedString = InsertFezz(myString);
                return insertedString;
            }

            return myString;
        }

        static string Reverse(int num, string myString)
        {
            if (num % 17 == 0)
            {
                if (myString.Contains("Fezz") && myString.Contains("Bong"))
                {
                    return myString;
                }

                if (myString.Contains("Fezz"))
                {
                    var fezzlessString = myString.Remove(myString.IndexOf("Fezz"));
                    var reversedFezzlessString = ReverseWordsInString(fezzlessString);
                    var reversedFezzfulString = InsertFezz(reversedFezzlessString);
                    return reversedFezzfulString;
                }

                var reversedString = ReverseWordsInString(myString);
                return reversedString;
            }
            return myString;
        }

        static IEnumerable<string> Split(string str)
        {
            while (str.Length > 0)
            {
                yield return new string(str.Take(4).ToArray());
                str = new string(str.Skip(4).ToArray());
            }
        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseWordsInString(string myString)
        {
            var stringList = Split(myString);
            List<string> revStringList = new List<string>();
            foreach (var str in stringList)
            {
                var revStr = ReverseString(str);
                revStringList.Add(revStr);
            }

            string combinedRevStrs = string.Join("", revStringList);
            string combinedStrings = ReverseString(combinedRevStrs);

            return combinedStrings;
        }

        public static string InsertFezz(string myString)
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


    static void Main(string[] args)
        {
            for (var i = 1; i < 270; i++)
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