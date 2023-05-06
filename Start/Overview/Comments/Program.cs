using System;

namespace Comments
{
    class Program
    {
    
    // Don't split up the XML section or the auto generation fails
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main sample application function
        /// </summary>
        /// <param name='args'> 
        /// An array of string arguments from the command line 
        /// </param>
        /// <returns>
        /// No return value
        /// </returns>

    // XML Comments allow the developer to automatically generate 
    //      documentation, directly from the source code.
    // The important thing is understanding the use of the correct
    //      XML elements when referencing in the code
    // Learn more at the following link
    //   https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/

    // **IMPORTANT**: You must modify the csproj file to tell the compiler to 
    //                create the documentation based on the below XML
        static void Main(string[] args)
        {
            // Single line comments start with two slashes 
            // You can have as many of these as you want
            //      The more lines you have, however, the more likely
            //      the use of multi-line comments would help
            Console.WriteLine("Hello World!");

            /* Multiple line comments start with a slash and a star
               and can continue for several lines until a closing
               star and slash are encountered */

        }
    }
}
