using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork2
{
    class DateDiff
    {
       
        public DateTime GetDate()
        {
            Console.WriteLine("Enter a date.");
            string userInput = Console.ReadLine();

            DateTime result;
            DateTime.TryParse(userInput, out result);
            
            return result;  
        }

        static void Main(string[] args)
        {
            DateDiff date1 = new DateDiff();
            DateDiff date2 = new DateDiff();

            DateTime d1 = date1.GetDate();
            DateTime d2 = date2.GetDate();

            TimeSpan diff; 

            if (d1.Year > d2.Year)
            {
                diff = d1.Subtract(d2);
                
            }
            else if (d1.Year < d2.Year)
            {
                diff = d2.Subtract(d1);
            }
            else
            {
                if(d1.Month > d2.Month)
                {
                    diff = d1.Subtract(d2);
                }
                else if(d1.Month > d2.Month)
                {
                    diff = d2.Subtract(d1);
                }
                else
                {
                    if (d1.Day > d2.Day)
                    {
                        diff = d1.Subtract(d2);
                    }
                    else
                    {
                        diff = d2.Subtract(d1);
                    }
                }
            }

            
            Console.WriteLine("The difference between the two dates is " + diff.TotalDays + " days.");
            Console.ReadLine();
        }
    }

    
}
