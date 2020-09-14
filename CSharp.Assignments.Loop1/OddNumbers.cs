using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number.
        /// Then, Write all odd integers between start and ending number inclusive
        /// (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Error.WriteLine("Enter the ending number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for(int i = n1; i <=n2; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine($"{i}");
                }
               
            }
        }
    }
}
