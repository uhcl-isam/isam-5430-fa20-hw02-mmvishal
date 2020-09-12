using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
            int n = 0;
            Console.Write("Enter Value of n: ");
            //string ninput = Console.ReadLine();
            n = int.Parse(Console.ReadLine());
            if (n>0)
            {
                for(int i=1;i<=n;i++)
                    {
                        Console.WriteLine(i);
                    }
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
