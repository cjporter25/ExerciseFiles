using System;

namespace MultiValues
{
    class Program
    {
        // **IMPORTANT** - Tuples are valuable because they offer a way
        //                 to return multiple values from a function
        static void Main(string[] args)
        {
        // TODO: Tuples are grouped values added in C# 7
            // Establish the variable types, then the variable name
            //      and assign to appropriate values
            (int a, int b) tup1 = (5, 10);
            // Create a basic implicit tuple. Variables can be of any
            //  type.
            // Items inside are automatically named as "Item1" and "Item2".
            var tup2 = ("Some text", 10.5f);

        // TODO: Tuple values are mutable by referring to them directly
            tup1.b = 20;
            tup2.Item1 = "New String";
            Console.WriteLine($"{tup1.a}, {tup1.b}");
            Console.WriteLine($"{tup2.Item1}, {tup2.Item2}");
        // TODO: Functions can work with tuples
            // Implicitly state that "result" is a tuple with two integers and
            //      assign it to the return tuple from "PlusTimes"
            (int, int) result = PlusTimes(6, 12);
            // Since result is a tuple with two items, we can refer to them
            //  using the keywords Item1 & Item2
            Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");
        }

        // TODO: Functions can return multiple values using tuples

        static (int, int) PlusTimes(int a, int b) {
            return (a+b, a*b);
        }
    }
}
