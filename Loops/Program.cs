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
            //   Console.WriteLiine(i);  
            // }

            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //// Console.WriteLine("After the loops has run, I now have the value of " + i) <-- Example

            //for (int i = 50; i >= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // FOR LOOPS WITH ARRAYS   
            // for(int i=0; i<days.Length; i++)	
            //{
            //    Console.WriteLine(days[i]);
            //}

            // The .Split() method takes ad string and turn it into an array of smaller 
            // ... string (substrings). It defaults the split on space.

            //string greeting = "My name is little Bill.";
            //string[] wordsInGreetings = greeting.Split();

            //for (int i = 0; i < wordsInGreetings.Length; i ++)
            //{
            //    Console.WriteLine(wordsInGreetings[i]);
            //}


            // Create an array called days with the elements Monday, Tuesday, and Wednesday. 
            // Using a For Loop, print the elements of the days array.

            //SPLT
            //string weeks = "Monday. Tuesday. Wednesday.";
            //string[] dayOfWeeks = weeks.Split();

            //for (int i = 0; i < dayOfWeeks.Length; i ++)
            //{
            //    Console.WriteLine(dayOfWeeks[i]);
            //}

            // Orginal Problem
            //string[] weekdays = { "Monday. Tuesday. Wednesday." };
            //for (int i = 0; i < weekdays.Length; i++)
            //{
            //    Console.WriteLine(weekdays[i]);
            //}

            //// Start with the string "Once upon a time" and create an array called storyWords using the Split method.
            //// Reverse the order of the elements in the array and using a For Loop, print each word.
            //string sentence = "Once upon a time";
            //string[] storyWords = sentence.Split();

            //Array.Reverse(storyWords);

            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            // Determine a proudct (multpication) of 1 through 10 using a For Loop
            // Print the product to the screen

            // ONE WAY
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //    Console.WriteLine(product);

            //// ANOTHER WAY
            //int product = 1;
            //for (int i = 1; i <= 10; i ++)
            //{
            //    product = product * i;
            //}
            //    Console.WriteLine(product);








        }
    }
}
