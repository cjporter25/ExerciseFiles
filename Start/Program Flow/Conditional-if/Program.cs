using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 55;

        // **IMPORTANT**: The practical limit for conditionals is 4 or 5 blocks. If
        //                the code exceeds that, consider using a switch block

        // TODO: if-else 
            if (theVal == 50) {
                Console.WriteLine("theVal is 50");
            } else if (theVal >= 51 && theVal <= 60) {
                Console.WriteLine("theVal is between 51 and 60");
            } else {
                Console.WriteLine("theVal is something else");
            }


        // -----------------------
        // TODO: Using the ternary operator ?:
        // WHY?: Shortening the if-else statements
            // If the expression is TRUE, it evaluates to the first option
            // If the expression is FALSE, it evaluates to the second option
            Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");

            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: can be replaced by a ternary operator ?:

        }
    }
}
