using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class Logic1
    {
        /// <summary>
        /// When squirrels get together for a party, they like to have cigars.
        /// A squirrel party is successful when the number of cigars is between 40 and 60, inclusive.
        /// Unless it is the weekend, in which case there is no upper bound on the number of cigars.
        /// Return true if the party with the given values is successful, or false otherwise.
        /// </summary>
        /// <param name="cigars"></param>
        /// <param name="isWeekend"></param>
        /// <returns></returns>
        public static bool CigarParty(int cigars, bool isWeekend)
        {
            if(isWeekend && (cigars >=40))
            {
                return true;
            }
            else if((cigars >= 40 && cigars <= 60))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// You are driving a little too fast, and a police officer stops you.
        /// Write code to compute the result, encoded as an int value: 0=no ticket,
        /// 1=small ticket, 2=big ticket. If speed is 60 or less, the result is 0.
        /// If speed is between 61 and 80 inclusive, the result is 1.
        /// If speed is 81 or more, the result is 2.
        /// Unless it is your birthday -- on that day,
        /// your speed can be 5 higher in all cases.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="birthday"></param>
        /// <returns></returns>
        ///

        public static int CaughtSpeeding(int speed, bool birthday)
        {
            int result = -1;
          
           if (birthday == true)
            {
                speed = speed - 5;
            }
                

            if (speed<=60)
            {
                result = 0 ;
            }
            else if((speed >=61) && (speed <=80))
            {
                result= 1;
            }
            else if(speed>=81)
            {
                result= 2;
            }

            return result;

        }

        /// <summary>
        /// The number 6 is a truly great number.
        /// Given two int values, a and b, return true if either one is 6.
        /// Or if their sum or difference is 6.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Love6(int a, int b)
        {
            if((a==6) || (b==6) || (a + b == 6) || (Math.Abs(a - b) == 6))
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        /// <summary>
        /// Return true if the given non-negative number is 1 or 2 more
        /// than a multiple of 20.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool
            More20(int num) //doubt
        {
            if((num % 20 ==2 )|| (num % 20 ==1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given a non-negative number "num",
        /// return true if num is within 2 of a multiple of 10.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool NearTen(int num)
        {
            if (num % 10 == 8 || num % 10 == 9 || num % 10 == 0 || num % 10 == 1 || num % 10 == 2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// We are having a party with amounts of tea and candy.
        /// Return the int outcome of the party encoded as 0=bad, 1=good, or 2=great.
        /// A party is good (1) if both tea and candy are at least 5.
        /// However, if either tea or candy is at least double the amount of the other one,
        /// the party is great (2). However, in all cases, if either tea or candy is less than 5,
        /// the party is always bad (0).
        /// </summary>
        /// <param name="tea"></param>
        /// <param name="candy"></param>
        /// <returns></returns>
        public static int TeaParty(int tea, int candy)
        {
            if((tea >= 5) && (candy >= 5))
            {
                if( tea == 2 * candy || candy == 2 * tea)
                {
                    return 2;
                }
                return 1;
            }
            else if((tea < 5) || (candy < 5))
            {
                return 0;
            }
            else
            {
                return 2;
            }

             
        }

        /// <summary>
        /// The squirrels in Palo Alto spend most of the day playing.
        /// In particular, they play if the temperature is between 60 and 90 (inclusive).
        /// Unless it is summer, then the upper limit is 100 instead of 90.
        /// Given an int temperature and a boolean isSummer, return true if the squirrels play and false otherwise.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="isSummer"></param>
        /// <returns></returns>
        public static bool SquirrelPlay(int temperature, bool isSummer)
        {
            bool result=true;

            if(isSummer==true)
            {
                if((temperature>=60 )&& (temperature<=100))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else if((temperature>=60) && (temperature<=90))
            {
                result= true;
            }
            else
            {
                result= false;
            }
            return result;
        }

        /// <summary>
        /// Given a day of the week encoded as DayOfWeek enum (i.e. named integers): 
        /// Sunday=0, Monday=1, Tuesday=2, ...Saturday=6, 
        /// and a boolean indicating if we are on vacation--
        /// return a string in the form of "7:00" indicating when the alarm clock should ring. 
        /// on weekends, the alarm should ring at "10:00", but
        /// on the weekdays, the alarm should ring at "7:00" unless we are on vacation,
        /// in which the alarm will then ring at "10:00" on the weekdays but "off" during the weekend.
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <param name="vacation"></param>
        /// <returns>either: "7:00" or "10:00" or "off"</returns>
        public static string AlarmClock(DayOfWeek dayOfWeek, bool vacation)
        {
            string x = " ";
            if(vacation == true)
            {
                if(((int)dayOfWeek >= 1) && ((int)dayOfWeek <= 5))
                {
                    x = "10:00";
                }
                else
                {
                   x="off";
                }
            }
            else if (vacation == false)
            {
                if (((int)dayOfWeek == 0) || ((int)dayOfWeek == 6))
                {
                    x="10:00";
                }
                else
                {
                    x="7:00";
                }
            }
            return x;
            
        }


        /// <summary>
        /// Your cell phone rings.Return true if you should answer it.
        /// Normally you answer, except in the morning you only answer if it is your mom calling.
        /// In all cases, if you are asleep, you do not answer.
        /// </summary>
        /// <param name="isMorning"></param>
        /// <param name="isMom"></param>
        /// <param name="isAsleep"></param>
        /// <returns></returns>
        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
           if(isAsleep == true)
            {
                return false;
            }
            else
            {
                if( isMorning==false)
                {
                    return true;
                }
                else
                {
                    if (isMom == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        /// <summary>
        /// A hilly number is defined to be a number with all the left digits in an ascending order, 
        /// followed by all the right digits in an descending order. 
        /// The top of the hill can be flat (i.e., it can have the same maximum numbers). 
        /// This has a computational complexity of O(m).
        /// Use % 10 and / 10 to fetch and reduce each digit.
        /// </summary>
        /// <param name="number">Number.</param>
        public static bool IsHilly(int number)
        {
            
            int x = 0, y = 0, flag=0;
            if(number>99)
            {
                while (number != 0)
                { 
                    x = number % 10 ;
                    number = number / 10;
                    if (number == 0)
                     return false;
                    y = number % 10;
                    if(flag==0)
                    {
                        if (x <= y)
                        {
                            flag = -1;
                        }
                        else
                            return false;
                    }
                    else if(flag==-1)
                    {
                            if (y < x)
                            {
                            //return false;
                            flag = 1;
                            if (number == y)
                                return true;
                            }

                    }
                    else
                    {
                       if(y>x)
                        {
                            return false;
                        }
                        if (number == y)
                            return true;
                    }

                }
            }
            else
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Given three ints, a b c, return true if one of b or c is "close"
        /// (differing from a by at most 1),
        /// while the other is "far", differing from both other values by 2 or more.
        /// Note: Math.abs(num) computes the absolute value of a number.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool CloseFar(int a, int b, int c) //doubt
        {
            return ((Math.Abs(a - b) <= 1 && (Math.Abs(a - c) >= 2 && Math.Abs(b - c) >= 2) ||
                    (Math.Abs(a - c) <= 1 && Math.Abs(a - b) >= 2 && Math.Abs(b - c) >= 2)));
        }
    }
}
