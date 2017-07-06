using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // When would you use a loop?
            // Why would you use a loop?
            // Nested Loops
            // Infinit Loops
            // Keyword break and continue 

            // * For Loop 
            //   - Can be used for both counting and interating through and array.
            // Looks like this: 
            // for(initializer; condition; updater)
            // {
            //      Do something 
            // }

            // for (int i = 0; i < 0; i++)
            // {
            //   Console.WriteLiine(i);     //       Console.WriteLine(i);
            // }

            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //// Console.WriteLine("After the loops has run, I now have the value of " + i) <-- Example

            for (int i = 100; i >= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
