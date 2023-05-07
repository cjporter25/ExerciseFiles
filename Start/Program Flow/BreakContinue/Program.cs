using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

            Console.WriteLine("Using break and continue :");
            foreach (int val in values)
            {
            // TODO: The continue statement skips the rest of the loop entirely
            // and jumps to the next iteration (if there is one)
                // If value is > or = to 20 and val is < or = 29 ...
                //      DONT'T execute anything else and instead move
                //      immediately to the next iteration of the loop.
                if (val >= 20 && val <= 29){
                    continue;
                }


                // print the value
                Console.WriteLine($"val is currently {val}");

            // TODO: The break statement stops the loop and exits
                // Stop loop from executing further if the currently
                //  referenced value is 40
                if (val >= 40) {
                     break;
                }

            }
        }
    }
}
