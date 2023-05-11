using System;
using System.Text; // Contains the StringBuilder Class

namespace Builder
{
    class Program
    {
        // For more information on string builders, check the link below
        // Link: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-7.0
        static void Main(string[] args)
        {
            // **IMPORTANT**: Improtant to understand that in .NET, a string object is immutable.
            //                Therefore, when making a new string, the string is first copied and
            //                then manipulated. This costs extra memory resources.
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

        // TODO: create a StringBuilder
            // Basic StringBuilder object
            StringBuilder sb1 = new StringBuilder();
            // Initializing a new StringBuilder with content already there, as well as
            //  a maximum string size.
            StringBuilder sb = new StringBuilder("Initial String Content", 200);
            
        // TODO: print some basic stats about the StringBuilder
            // Use an interpolated string to output the stringbuilder's Capacity and current
            //  length
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

        // TODO: Add some strings to the builder using Append
            // The append function does the same thing for stringbuilders as it does for strings.
            // NOTE: Append is limited to explicit non-formatted strings
            sb.Append("The quick brown fox ");
            sb.Append("jumped over the lazy dog");

        // TODO: AppendLine can append a line ending
            // Using the function "AppendLine()" the user can add an "endline" to the string
            sb.AppendLine();

        // TODO: AppendFormat can be used to append formatted strings
            // Using the function "AppendFormat()" the user can append a formatted string.
            sb.AppendFormat("He did this {0} times.", jumpCount);
            sb.AppendLine();

        // TODO: AppendJoin can iterate over a set of values and add them to a string
            sb.Append("He also jump over ");
            // For each item in "animals" add the object's value and add a comma
            sb.AppendJoin(',', animals);


        // TODO: Modify the content using Replace
            // Functions the same as "replace" for a noraml string, i.e., you can replace
            //  a specified string or character with something else.
            sb.Replace("fox", "cat");


        // TODO: Insert content at any index
            // Functions the same as "insert" for a noraml string, i.e., you can insert
            //  a specified string at the index of your choosing
            sb.Insert(0, "This is the ");
            
        // TODO: Convert to a single string
            // Reouput string size values
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            // WHEN STRINGBUILDING IS FINISHED --> Convert into a normal string
            Console.WriteLine(sb.ToString());

        }
    }
}
