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
            Console.ReadLine();         
        }

                
        static void Main(string[] args)
        {
            DateDiff date1 = new DateDiff();
            DateDiff date2 = new DateDiff();

            DateTime d1 = date1.GetDate();
            DateTime d2 = date2.GetDate();

            TimeSpan diff = d1.Subtract(d2);

            Console.WriteLine(diff.TotalDays);
            Console.ReadLine();
        }
    }
}
