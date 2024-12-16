using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOuts
{
    public class Switch
    {

        static void Main(string[] args)
        {
            int day = 1;
            string dayString;
            switch (day)
            {
                case 1:
                case 2:
                    dayString = "Monday";
                    break;
                case 3:
                    dayString = "Tuesday";
                    break;
                case 4:
                    dayString = "Wednesday";
                    break;
                case 5:
                    dayString = "Thursday";
                    break;
                case 6:
                    dayString = "Friday";
                    break;
                case 7:
                    dayString = "Saturday";
                    break;
                default:
                    dayString = "Invalid day";
                    break;
            }
            Console.WriteLine(dayString);

            /*
            The above code displays 'Monday' as output for day=1.
            Change day=2, again the output is 'Monday'.
            If no statement is written inside the satisfied switch case
            then the output is considered from the very next switch case.
            */

            //Uncomment the following lines of code and execute the program.

            /*
            switch (day)
            {
                case 1:
                    dayString = "Sunday";
                    
                case 2:
                    dayString = "Monday";
                    break;
                case 3:
                    dayString = "Tuesday";
                    break;
                case 4:
                    dayString = "Wednesday";
                    break;
                case 5:
                    dayString = "Thursday";
                    break;
                case 6:
                    dayString = "Friday";
                    break;
                case 7:
                    dayString = "Saturday";
                    break;
                default:
                    dayString = "Invalid day";
                    break;
            }
            Console.WriteLine(dayString);
            */

            /* 
            The above code results in compilation error.
            If any statement is written inside switch case then break statement is mandatory.
            */
        }
    }
}
