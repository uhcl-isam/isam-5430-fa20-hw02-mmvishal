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
            int number;
            int counter = 1;

            int tempValue = 0;
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            //Console.WriteLine("Enter number to determine the first and second largest number: ");

            while (counter <= 10)
            {
                number = int.Parse(Console.ReadLine());

                if (number >= largest)
                {
                    tempValue = largest;
                    largest = number;
                    secondLargest = tempValue;

                }
                else if (number >= secondLargest)
                {
                    secondLargest = number;
                }

                counter++;
            }
            Console.WriteLine(largest);
            Console.WriteLine(secondLargest);
            Console.WriteLine(counter);
        }
    }
}
