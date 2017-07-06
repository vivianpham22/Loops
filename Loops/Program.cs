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



            // Foreach loop 
            // - used to iterate over a collection (ex. list or array)
            // You can think the structure of a foreach loop as the statement:
            // For each item in the collection, do something. 

            //foreach (dataType variable in collection)
            //{
            //    do something
            //}

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword FOREACH
            //foreach(string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            // foreach loops allow the temporary variable to "know" to assign
            // itself to each elemt in the collection (like an array), one at a time

            // Foreach loop will always go from beginning to end, no matter what
            // It counts the numbers of elements in the collection, and runs that many times

            // Create an array of 6 musicians (band or solo artist)
            // Using aa foreach loop, print musicans name

            //string[] musicians = { "Alesso", "Hardwell", "Son Halo", "Dillon Francis", "Jason Aldean", "JBiebs" };
            //foreach (string artist in musicians)
            //{
            //    Console.WriteLine(artist);
            //}


            //// WHILE LOOP 
            //// - used when you want a chunk of code to run only if a condition is met
            //// - While something is TRUE, do this thing.
            //// - infinit loop if condition is met

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "VIVIAN")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}

            //Console.WriteLine("Do you want to play this game? YES/NO");
            //string playAgain = Console.ReadLine(); //.ToUpper();
            //while (playAgain.ToUpper() == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    // break; 
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}



            //// DO - WHILE LOOP
            //// - used when you want a chunk of code to run
            //// - AT LEAST ONCE, but repeat only if the While Condition is met

            //// do-while structure looks like this 

            //// do
            //// {
            ////      Do something
            //// }
            //// while(condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to the game!");
            //    //let's pretend the code for the game is here
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine(); //.ToUpper();
            //}
            //while (playAgain == "YES");


            // Ask the user for the class they would like to add to their GPA calculation
            // Ask the user for the letter grade for the class (no + or - grade)
            // Ask the user if they have another class they would like to add to their GPA calculation
            // Using a Do While Loop, repeat the code if the user says "YES"


            //string gpaCalc;
            //do
            //{
            //    Console.WriteLine("Would you like to add a class to your GPA calculation? YES/NO");
            //    gpaCalc = Console.ReadLine().ToLower();

            //    string gpaCalc2;
            //    Console.WriteLine("Name of class you want to add?");
            //    gpaCalc2 = Console.ReadLine();

            //    string letterGrade;
            //    Console.WriteLine("Grade for class?");
            //    letterGrade = Console.ReadLine();

            //}
            //while (gpaCalc == "YES");




            //// NESTED LOOPS
            //// - loop inside a loop
            //// - the inner loop is executed more times than the outer loop
            //// REAL LIFE EXAMPLE: CLOCK 

            //// Create a nested loop structure that prints:
            //// 1234
            //// 1234

            //// How many rows and colums are there ?
            //// 2 rows
            //// 4 colums

            //for (int rows = 1; rows <= 2; rows++)
            //{
            //    for (int colums = 1; colums <= 4; colums++)
            //    {
            //        Console.Write(colums);
            //    }
            //    Console.WriteLine();
            //}


            //// Print a triangle
            //// Outer loop will out line by line
            //// Inner loop will over over the different elements 
            //// Results
            //// 1
            //// 1 2
            //// 1 2 3
            //// 1 2 3 4 ....

    
            //for (int row = 1; row <= 4; row++)
            //{
            //    for (int colums = 1; colums <= row; colums++)
            //    { 
            //        Console.Write(colums);
            //    }
            //    Console.WriteLine();                        
            //}

            //// Another way 
            //Console.WriteLine("How many rows do you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int colums = 1; colums <= row; colums++)
            //    {
            //        Console.Write(colums + " ");
            //    }
            //        Console.WriteLine();  
            //}
                










        }
    }
}