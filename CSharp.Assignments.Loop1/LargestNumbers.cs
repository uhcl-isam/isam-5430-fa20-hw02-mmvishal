using System;
using System.Diagnostics;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    /// 
   // [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class LargestNumbers
    {
        public static void Main()
        {
            // get first number and assign it to variable largest
            // write your codes here


            int counter = 0;
            int number = 0;
            int largest = 0;
            int second = 0;

            for (counter = 0; counter < 10; counter++)
            {
               // Console.WriteLine("Enter the integer: ");
                number = int.Parse(Console.ReadLine());

                {
                    if (counter == 0)
                    {
                        largest = number;
                    }
                    else
                    {
                        if (number > largest)
                        {
                            largest = number;
                        }
                        if (number > second && number < largest)
                        {
                            second = number;
                        }
                    }
                }
            }

            Console.WriteLine(largest);
            Console.WriteLine(second);
        }
    }

}
