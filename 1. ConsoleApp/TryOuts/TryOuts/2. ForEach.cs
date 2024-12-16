using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOuts
{
    using System;

    class ForEach
    {
        private static void Main(string[] args)
        {
            // The array is the collection of string values - course names
            string[] courses = {
                                "Basic C# Programming",
                                "Advanced C# Programming",
                                "SQL Server"
                            };
            // foreach is used to loop through each item in the array
            // Syntax for foreach is:
            // foreach (var item in collection)
            // {
            //     // statements
            // }
            // where 'var item' - is the local variable similar to 'int item'
            // this variable is local to the foreach loop
            // collection is the name of the array
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            /* For every iteration the value of the current array element of courses
            is assigned to the local variable course until the end of the array is reached. */
        }
    }

}
