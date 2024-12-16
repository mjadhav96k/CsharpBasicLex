using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOuts
{

        class BreakAndContinue
        {
                static void Main(string[] args)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            continue;
                            // The control after continue statement goes to the next loop iteration (of the outer for loop)
                            // and the remaining lines of code - else block and the Console.WriteLine() are skipped.
                        }
                        else
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                if (j != i)
                                {
                                    Console.WriteLine(j);
                                }
                                else
                                {
                                    break;
                                    /*The control after break goes out of the current loop (the inner for loop).
                                    In this case the control jumps out of the inner loop 
                                    and continues with the next statement execution - here it is 
                                    the outer for loop statements - Console.WriteLine()
                                    at line number - 33.*/
                                }
                            }
                        }
                        Console.WriteLine("");

                    }
                }
        }

}

