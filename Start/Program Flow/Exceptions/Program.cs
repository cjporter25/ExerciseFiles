using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 0;
            int result;

        // TODO: try-catch expressions make error checking easier
            // The following is a general exception catcher that will 
            //  catch any exception thrown and print out what's in the
            //  catch block
            try {
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            } catch {
                Console.WriteLine("Whoops!");
            } 

            // The following checks for a specified type of exception
            //      which in this case is a divide by zero exception.
            // Assigning this declaration to a variable means I can
            //      use it and pull the exception objects message variable
            //      to output to the console.
            try {
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            } catch (DivideByZeroException e) {
                Console.WriteLine("Whoops!");
                Console.WriteLine(e.Message);
            } 

            // The following is an example of creating my own qualifier
            //      for some type of exception I choose
            // Here, I say that anything over 1000 should be considered
            //      "Out of Range"
            x = 1001;
            try {
                if (x > 1000) {
                    // Throw an exception stating x has to be under a 1000
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            } catch (DivideByZeroException e) {
                Console.WriteLine("Whoops!");
                Console.WriteLine(e.Message);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Sorry, 1000 is the limit");
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("The 'finally' block always runs");
            }

            
        }
    }
}
