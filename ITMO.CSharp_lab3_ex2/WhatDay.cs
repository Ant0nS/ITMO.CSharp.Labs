using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp_lab3_ex2
{
    class Program
    {
        enum MonthName
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        class WhatDay
        {
            static void Main()
            {
                try
                {
                    Console.Write("Please enter a day number between 1 and 365: ");
                    string line = Console.ReadLine();
                    int dayNum = int.Parse(line);
                    if (dayNum < 1 || dayNum > 365)
                    {
                        throw new ArgumentOutOfRangeException("Day out of range");
                    }
                    int monthNum = 0;
                    int[] DaysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                    MonthName temp = (MonthName)monthNum;
                    string monthName = temp.ToString();
                    Console.WriteLine("{0} {1}", dayNum, monthName);
                }
                catch (Exception caught)
                {
                    Console.WriteLine("Error: " + caught.Message );
                }
                Console.ReadKey();
            }
        }
    }
}
