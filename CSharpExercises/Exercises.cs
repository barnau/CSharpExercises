﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{


    public static class Exercises
    {


        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")

        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.

        public static float Divide(float x, float y)
        {
            return x / y;
        }

        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.

        public static bool CanOpenCheckingAccount(int age)
        {
            return age >= 18;
        }


        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.

        public static string GetFirstName(string fullName)
        {
            char delimiter = ' ';
            String[] substrings = fullName.Split(delimiter);
            return substrings[0];

        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)

        public static string ReverseStringHard(string input)
        {
            string returnString = "";
            for (int i = (input.Length); i > +0; i--)
            {
                returnString += input[i - 1];
            }

            return returnString;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)

        public static string ReverseStringEasy(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        public static string PrintTimesTable(int num)
        {
            string returnString = "";

            for (var i = 1; i < 10; i++)
            {
                returnString += num + " * " + i + " = " + (i * num) + System.Environment.NewLine;
            }
            returnString += num + " * " + 10 + " = " + (10 * num);
            return returnString;
        }
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double tempKelvin)
        {
            double tempFahr = tempKelvin * 9 / 5 - 459.67;
            
            return Math.Round(tempFahr, 2);

        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)

        public static double GetAverageHard(int[] averageThis)
        {
            double total = 0;
            double score = 0;
            for (var i = 0; i < averageThis.Length; i++)
            {
                score = System.Convert.ToDouble(averageThis[i]);
                total += score;
                
            }
            return System.Convert.ToDouble(total / averageThis.Length);
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)

        public static double GetAverageEasy(int[] averageThis)
        {
            

            return averageThis.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        public static string DrawTriangle(int number, int width)
        {
            string returnString = "";
            for (var i = width; i >= 0; i--)
            {
                for (var x = i; x >= 1; x--)
                {
                    returnString += number.ToString();
                }
                if (i >= 2)
                {
                    returnString += System.Environment.NewLine;
                }
                
            }

            return returnString;
        }
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers 
        // representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {

            int hoursInSeconds = hours * 60 * 60;
            
            int minutesInSeconds = minutes * 60;
            

            int totalInSeconds = seconds + minutesInSeconds + hoursInSeconds;
            

            double mps = distance / System.Convert.ToDouble(totalInSeconds);
           

            double mph = Math.Round(mps * 60 * 60);
            
            return (mph + "MPH").ToString();
            
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letterToTest)
        {
            char[] vowels = { 'a', 'e','i', 'o', 'u' };

            foreach(char vowel in vowels)
            {
                if(vowel == letterToTest)
                {
                    return true;
                }
            }
            return false;
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char letterToTest)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {
                if (vowel == letterToTest)
                {
                    return false;
                }
            }
            return true;
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int num)
        {
            var count = 0;
            while(num > 1)
            {
                count += 1;
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }
               
            }
            

            return count;
        }


        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime day)
        {
            //new DateTime(2016, 8, 22)
            DateTime[] returnArray = new DateTime[7];

            for (int i = 0; i < 7; i++)
            {
                returnArray[i] = day.AddDays(i);
                
            }

            
            return returnArray;
        }


        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(DateTime date)
        {
            

            int year = date.Year;
            int lastTwo = year % 100;
            Console.WriteLine(lastTwo);

            if(year % 4 == 0)
            {

                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            } else
            {
                return false;
            }
         
        }

        // Create a method called GetOccurences that accepts two strings. The first string should represent a 
        //string of text, and the other should represent a single word. GetOccurrences should return the number of times that the given word appears in the string of text.
        public static int GetOccurences(string full, string search)
        {
            char[] delimiter = { ' ' , '.', '?', '!'};
            String[] substrings = full.Split(delimiter);
            int count = 0;
            foreach (string word in substrings)
            {
                Console.WriteLine(word.ToLower());
                if (word == search)
                {
                    count += 1;
                }
            }


            return count;
        }


        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double loanBalance, double interestRate, int longTerm, int period)
        {
            interestRate = interestRate / 100;
            double r = interestRate / period;
            
            double n = longTerm * period;
            
            var m = (r * Math.Pow(1 + r, n)) / (Math.Pow(1+r, n) - 1) * loanBalance;

            
            return Math.Round(m,2);
        }



        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        public static string DuckGoose(int iterations)

        {
            string returnString = "";

            for (var i = 1; i < iterations; i++)
            {
                
                if (i % 5 == 0 && i % 3 == 0)
                {
                    returnString += "DuckGoose" + Environment.NewLine;
                }
                else if (i % 5 == 0)
                {
                    returnString += "Goose" + Environment.NewLine;
                }
                else if (i % 3 == 0)
                {
                    returnString += "Duck" + Environment.NewLine;
                } else
                {
                    returnString += (i) + Environment.NewLine; 
                }
            }

            if (iterations % 5 == 0 && iterations % 3 == 0)
            {
                returnString += "DuckGoose" ;
            }
            else if (iterations % 5 == 0)
            {
                returnString += "Goose";
            }
            else if (iterations % 3 == 0)
            {
                returnString += "Duck";
            }
            else
            {
                returnString += iterations;
            }

            //apply to else if to iterations number once





            return returnString;

        }

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}