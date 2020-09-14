using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            int accnumber;
            int beginningbalance, totalcharges, totalcredits, creditlimit, accountbalance;
            Write("Enter Account Number: ");
            accnumber = int.Parse(Console.ReadLine());

            while(accnumber>0)
            {
                Write("Enter Balance at begining of the month: ");
                beginningbalance = int.Parse(Console.ReadLine());
                Write("Enter total of all items charged by the customer this month: ");
                totalcharges = int.Parse(Console.ReadLine());
                Write("Enter total of all credits applied to the customer’s account this month: ");
                totalcredits = int.Parse(Console.ReadLine());
                Write("Enter Credit Limit: ");
                creditlimit = int.Parse(Console.ReadLine());

                accountbalance = beginningbalance + totalcharges - totalcredits;

                WriteLine($"New Account Balance: {accountbalance}");

                if (accountbalance>creditlimit)
                {
                    WriteLine("Credit limit Exceeded");
                }
                else
                {
                    WriteLine($"Account Number:{accnumber}");
                    WriteLine("Enter Account Number: ");
                    accnumber = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}
