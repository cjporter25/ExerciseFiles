using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

        // TODO: Declare an array of values
            //Blank array of 5 integers
            int[] vals = new int[5]; 
            //Immediately assign a string array to three predetermed strings
            string[] strs = {"one", "two", "three"}; 

        // TODO: Print the values using a Formatting String
            // The brackets will contain the referenced variables based on their order
            //  and be printed as such
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i,c,b,str,f,d,x,z);

        // TODO: "null" means "no value"
            // Can create an "object" of class object and set it to null
            // If you print it, nothing will print
            object obj = null;
            Console.WriteLine(obj);

        // TODO: Implicit conversion between types
            // This conversion only works because a "long" is also an integer object
            long bignum;
            bignum = i;

        // TODO: Explicit conversions
            // Explicitly casting an integer to a float
            float i_to_f = (float)i;
            Console.WriteLine("{0}", i_to_f);

            // Explicitly casting a float to an integer
            int f_to_i = (int)f;
            Console.WriteLine("{0}", f_to_i);
        }
    }
}
