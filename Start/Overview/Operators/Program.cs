using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
        // Declare some variables to excercise the operators
            int x=10, y=5;
            string a="abcd", b="efgh";

        // TODO: Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            // Basic Math Operation
            Console.WriteLine("(10 / 5) * 10) = " + ((x / y) * x)); // Out: 20
            // Adding strings concatenates them together
            Console.WriteLine("abcd + efgh = " + (a + b)); // Out: acbdefgh


        // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            // Increment x by 1 
            x++;
            //Decrement y by 1
            y--;
            Console.WriteLine("x = 10, x++, x now equals: " + x); // Out: 11
            Console.WriteLine("y = 5, y--, y now equals: " + y); // Out: 4


        // TODO: Operators can be shorthand: a = a + b
            // Set "a" to equal the sum of "a" and "b"
            a += b;
            Console.WriteLine("a = a + b, can be represented as a += b");
            Console.WriteLine("     a is 'abcd' and b is 'efgh'. 'a += b' = " + (a));

        // HOWTO: Comment out multiple lines
            // Console.WriteLine("comment test");
            // Console.WriteLine("comment test");
            // Console.WriteLine("comment test");


        // TODO: Logical operators &&, ||
            Console.WriteLine("----- Logic Operators -----");
            // Results in true if x is > y AND y is > or = to 5
                // IF either statement is false, the whole statement is false
            Console.WriteLine(x > y && y >= 5); 
            // Results in true if x is > y OR y is > or = to 5
                // IF both statements are false, the whole statement is false
            Console.WriteLine(x > y || y >= 5);


        // TODO: null-coalescing operators
            // NOTE: "null" means it has no value
            string str = null; 
        // TODO: the ?? operator uses left operand if not null, or right one if it is
            // The variable "str" is null, therefore, the ?? operator will pass the
            //  explicit string "Unknown string" to the console instead of str 
            Console.WriteLine(str ?? "Unknown string");

            
        // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            // If "str" is null, it is assigned the value of "New String"
            str ??= "New String";
            Console.WriteLine(str);

        }
    }
}
