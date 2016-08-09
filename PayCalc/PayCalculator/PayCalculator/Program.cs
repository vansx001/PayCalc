using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double userHour;
            double userRate;
            double userPay;

            Console.WriteLine("Enter your hours worked.");
            userHour = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pay rate.");
            userRate = Double.Parse(Console.ReadLine());

            userPay = userHour * userRate;
            Console.WriteLine("Your gross pay is:" + (userPay));
            Console.ReadLine();

            //Mike's way of calculating*
            //decimal hours;
            //decimal wages;
            //decimal gross;

            //Console.WriteLine("Enter hours worked: ");
            //string hoursWorked = Console.ReadLine();
            //Console.WriteLine("Enter hourly wage: ");
            //string hourlyWage = Console.ReadLine();

            //hours = Decimal.Parse(hoursWorked);
            //wages = Decimal.Parse(hourlyWage);
            //gross = hours * wages;
            //Console.WriteLine("Your gross pay: " + gross);
            //Console.ReadLine();

        }
    }
    }
