using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class DataConversion
{
    private static void Main(string[] args)
    {
        /* Implicit conversion from integer to double is called Widening conversion. 
        Storing value of smaller datatype to variable of bigger datatype */

        double doubleValue = 50;
        Console.WriteLine("Integer to double implicit conversion: " + doubleValue);


        /*Uncomment the below statement and observe the following error:
        Cannot implicitly convert type 'double' to 'int' */

        //int intValue0 = 5.5;


        /*Explicit conversion from double to int is called Narrowing conversion. 
        Storing value of larger datatype to variable of smaller datatype.
        Narrowing conversion will lead to data loss */

        int intValue1 = (int)(5.5);
        Console.WriteLine("Double to integer explicit type conversion: " + intValue1);

        //Explicit conversion from double to int
        int intValue2 = Convert.ToInt32(5.5);
        Console.WriteLine("Double to integer explicit type conversion: " + intValue2);

        string stringValue1 = "10";

        /* Uncomment the below statement and observe the following error: 
        Cannot implicitly convert 'str' to 'int' */

        //int intValue3 = stringValue1;

        /* Uncomment the below statement and observe the following error: 
        Cannot  convert 'str' to 'int' */

        //int intValue4 = (int)(stringValue1);

        /* The above statement gives error because int and string are incompatible datatypes*/

        int intValue5 = Convert.ToInt32(stringValue1);
        Console.WriteLine("String to int explicit Conversion: " + intValue5);

    }

}
