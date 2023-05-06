using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 53;

        // TODO: The switch statement
            // The value in the switch statement is the thing to evaluate
            switch (theVal) {
            // Establishes test cases to compare to the switch value
            case 50:
                Console.WriteLine("theVal is 50");
                // Break if a case was successfully executed. This prevents further
                //  cases from being checked
                break;
            case 51:
                Console.WriteLine("theVal is 51");
                break;
            // Can establish multiple cases in a row and have a final concluding
            //  execution occur based on the previous cases
            case 52:
            case 53:
            case 54:
                Console.WriteLine("theVal is between 52 and 54");
                break;
            // The default case occurs if none of the previous cases satisfied the
            //  compared to value
            default:
                Console.WriteLine("theVal is something else");
                break;
            }

        }
    }
}
