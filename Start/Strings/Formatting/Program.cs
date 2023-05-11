using System;

namespace Formatting
{
    class Program
    {

        // TO LEARN MORE ABOUT NUMERIC FORMATTING
        // Link: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        static void Main(string[] args)
        {
            int[] quarters = {1,2,3,4};
            int[] sales = {100000, 150000, 200000, 225000};
            double[] intlMixPct = {.386, .413, .421, .457};
            string str1 = "TestStr1";
            string str2 = "TestStr2";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic Formatting information. A number is encased in curly brackets
            //  and this number corresponds to the index of variable in the additional
            //  items list.
            Console.WriteLine("{0} {1}", str1, str2);
            Console.WriteLine("{0} {0}", str1);
            Console.WriteLine("{0} {0}", str2);

        // TODO: Specifying Numerical formatting
            // General format is {index[,alignment]:[format]}
            // Common types are N (Number), G (General), F (Fixed-point), 
            // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
            // C (Currency in local format)
                // Format "val1" to output as a decimal, traditional number style,
                //  Fixed-Point, or a general output.
                // Out: 1234, 1,234.00, 1234.00, 1234
            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
                // Format "val2" to output in scientific notation, or some other style
                // Out: 1.234568E+003, 1,234.57, 1234.57, 1234.5678
            Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);



        // TODO: Add a number after the format to specify precision, i.e., how
        //   many spaces the eventual output number should take up
            // Note: If number is too big, it will shrink to fit the precision
            //       number. If it's too small, extra zeros are added in front
            //       or behind as needed.
            // Out:  001234, 1,234.00, 1234.0, 1.23E+03
            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

        // TODO: Formatting with alignment and spacing
            // Output the quarters array such that each item in the array
            //  has a maximum of 12 spaces
            // Out:            1            2            3            4
            Console.WriteLine("{0, 12} {1, 12} {2, 12} {3, 12}",
                quarters[0], quarters[1], quarters[2], quarters[3]);

            // Output the sales array using the formatting style of "currency"
            //  and make sure they are given 12 spaces
            // Out:     $100,000     $150,000     $200,000     $225,000
            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}",
                sales[0], sales[1], sales[2], sales[3]);
            
            // Output the intlMixPct array using the formatting style of "percent"
            //  and make sure they are also given 12 spaces to work with.
            Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",
                intlMixPct[0], intlMixPct[1], intlMixPct[2], intlMixPct[3]);
        }
    }
}
