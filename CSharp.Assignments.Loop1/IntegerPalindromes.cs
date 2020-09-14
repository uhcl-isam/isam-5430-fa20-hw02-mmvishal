using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.

            int TempNum, TempNum2, remainder, reverse = 0;

            Console.WriteLine("Enter numbers to check whether the number is Palindrome or not: ");
            string number = (Console.ReadLine());

            while (number.Length > 9 || number.Length < 9)
            {
                Console.WriteLine("Number must be exactly 9 digits. Please try again :  ");
                number = (Console.ReadLine());
            }

            TempNum = Convert.ToInt32(number);
            TempNum2 = TempNum;
            while (TempNum > 0)
            {
                remainder = TempNum % 10;
                TempNum = TempNum / 10;
                reverse = reverse * 10 + remainder;
            }

            if (TempNum2 == reverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}