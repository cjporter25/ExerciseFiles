using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

        // TODO: Output information using formatting
            // Out: This car is a 2020 Mercedes-Benz G Class with 8450.27 miles and costs $60275.0
            Console.WriteLine("This car is a {0} {1} {2} with {3} miles and costs ${4}",
                             year, make, model, miles, price);


        // TODO: Using string interpolation (embedding variable rather than using formatting)
        //       To tell the compiler to process this string as an interpolated string, you
        //       must add a "$" before the quotes
        // Out: This car is a 2020 Mercedes-Benz G Class with 8450.27 miles and costs $60275.0
        Console.WriteLine($"This car is a {year} {make} {model} with {miles} miles and costs {price}");

        // You can also add formatting to interpolated strings
        Console.WriteLine($"This car is a {year} {make} {model} with {miles} miles and costs {price:C2}");
        Console.WriteLine($"This car is a {year} {make} {model} with {miles * 1.6:F2} miles and costs {price:C2}");

        // TODO: With inline expressions
        // Adding literal braces when needed. Simply encase one within two others
        Console.WriteLine($"This car is a {year} {make} {model} with {{{miles * 1.6:F2}}} miles and costs {price:C2}");

        }
    }
}
