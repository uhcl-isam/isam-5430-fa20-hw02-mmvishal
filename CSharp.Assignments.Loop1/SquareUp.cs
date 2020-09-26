using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0.
        /// The app will print out n*n integers with the following pattern;
        /// for n=3, the app will print out 0, 0, 1,    0, 2, 1,    3, 2, 1 on separate lines
        /// (spaces added to show the 3 groups).
        /// </summary>
         public static void Main()
            {
                Console.Write("Enter a number to display a square up: ");
                int number = int.Parse(Console.ReadLine());
                // Write your codes here.
                int n1 = number - 1;
                if (number >= 0)
                {
                    int n = 1;
                    do
                    {
                        for (int k = 0; k < n1; k++)
                        {
                            Console.Write("0");
                            Console.Write(" ");
                        }

                        for (int i = n; i > 0; i--)
                        {
                            Console.Write(i);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                        n++;
                        n1--;
                    } while (n <= number);
                }

            }
    }
}
