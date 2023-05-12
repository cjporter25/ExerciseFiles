using System;
using System.Globalization; // Contains the number styles class

namespace Parsing
{
    class Program
    {
        // NOTE: More string parsing methodolofies can be found at the below link:
        // Link: https://learn.microsoft.com/en-us/dotnet/standard/base-types/parsing-other
        static void Main(string[] args)
        {
            string numStr1 = "1";       // Simple Integer
            string numStr2 = "2.00";    // Decimal floating point
            string numStr3 = "3,000";   // English "thousands" marker via the comma
            string numStr4 = "3,000.00";// English thousands and a decimal floating point

            // **IMPORTANT** - The Parse function attempts to parse a string into 
            //                 a number but it might throw an exception, so we 
            //                 need to catch it if it does.

            int targetNum=0;
            try {
            // TODO: Use Parse to try converting string to a simple integer
                // Out: 1
                targetNum = int.Parse(numStr1);
                Console.WriteLine(targetNum);

            // TODO: Use Parse to try a floating point number. We first
            //       have to allow the parser to use floating point
            //       NOTE: This only works if the decimal value is 0
                // Tell a parser - "Expect to see a decimal ploating point #"
                    // Convert a decimal string to an integer
                    // Out: 2
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine(targetNum);


            // TODO: Use Parse to try a number with thousands marker
                // Tell a parser - "Expect to see a thousands marker in the string"
                    // Convert a thousands marked string to an integer
                    // Out: 3000
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);
            

            // TODO: Use Parse to try a number with thousands marker AND decimal
                // Tell a parser - "Expect a thousands marker or a decimal
                    // Convert a thousands marked decimal string to an integer
                    // Out: 3000
                targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

            // TODO: This works with other types too, like bool
                // Explicit Parse - The string "True" can be parsed and interpreted
                //                  as a boolean value. 
                // Out: True
                Console.WriteLine($"{bool.Parse("True")}");

            // TODO: Or floating point numbers
                // Explicit Parse - The string "1.234" can be parsed, formatted, and 
                //                  interpreted as a float value with a precision of 2
                // Out: 1.24
                Console.WriteLine($"{float.Parse("1.235"):F2}");

            }
            catch {
                Console.Write("Conversion failed");
            }

            // TODO: The TryParse function is similar but handles the exceptions for us
                bool succeeded = false;
                // TryParse - Combines the try catch block and the parsing function
                //            and returns a boolean value indicating whether the conversion
                //            was successful
                // "out" - In the second parameter, if the conversion was successful, the
                //         function "TryParse" will save the output into the selected param
                succeeded = Int32.TryParse(numStr1, out targetNum);

            if (succeeded) {
                Console.WriteLine($"{targetNum}");
            }
        }
    }
}
