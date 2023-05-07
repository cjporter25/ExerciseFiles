using System;

namespace Operations
{
    class Program
    {
        // **IMPORTANT**: For other string related information in C# 
        //                go to this link:
        // https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

        // TODO: Length of a string
            // NOTE: In C#, the length of a string is a property of the string.
            Console.WriteLine(str1.Length); // Out: 44

        // TODO: Access individual characters
            // Strings are interpreted as an array of characters, therefore
            //  by referencing it as an array, you can access each index
            Console.WriteLine(str1[14]); // Out: n

        // TODO: iterate over a string like any other sequence of values
            // Iterate over a string like an array of characters
            foreach (char ch in str1) {
                Console.Write(ch);
                if (ch == 'b'){
                    Console.WriteLine();
                    break;
                }
            } // Out: The quick b


        // TODO: String Concatenation
            // Using the "Concat" function on an array of strings will conjoin them
            //  together into one string.         
            outstr = String.Concat(strs);
            Console.WriteLine(outstr); // Out: onetwothreefour

        // TODO: Joining strings together with Join
            // Using the "Join" function on an array of strings will join them
            //  together by using the string specified by the first parameter.
            outstr = String.Join('.', strs);
            Console.WriteLine(outstr); // Out: one.two.three.four

            outstr = String.Join("---", strs);
            Console.WriteLine(outstr); // Out: one---two---three---four

        // TODO: String Comparison
        // The function "Compare" will perform an ordinal comparison 
        // of two strings and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result1 = String.Compare(str2, "This is a string"); 
            int result2 = String.Compare(str2, str3);
            int result3 = String.Compare(str3, str2);
            Console.WriteLine(result1); // Out: 0
            Console.WriteLine(result2); // Out: < 0
            Console.WriteLine(result3); // Out: > 0


        // TODO: Equals just returns a regular Boolean
            // Using "Equals" compares two strings and returns a boolean value
            //      as to whether the strings are equal or not
            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual); // Out: False

        // TODO: String Searching
            // Output the first discovered index location of "e"
            Console.WriteLine(str1.IndexOf('e'));
            // Output the first discovered index location of "fox"
            Console.WriteLine(str1.IndexOf("fox"));

            // Output the last discovered index location of "e"
            Console.WriteLine(str1.LastIndexOf('e'));
            // Output the last discovered idnex location of "the"
            Console.WriteLine(str1.LastIndexOf("the"));

            // In str1, replace the string "fox" with the string "cat"
            outstr = str1.Replace("fox", "cat");
            Console.WriteLine(outstr);
            // Because "fox" no longer exists, the output will be -1
            Console.WriteLine(outstr.IndexOf("fox"));
        
        }
    }
}
