using System;

namespace StringRep
{
    class Program
    {
        // ToString information at this link:
        // https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0
        static void Main(string[] args)
        {
        // TODO & IMPORTANT: Every class in C# inherits from Object, which means
        // that every class inherits the ToString() method.
        // PURPOSE: To return a string representation of the object that is suitable
        //          for display.
            int x = 1000;
            Console.WriteLine(x.ToString());
            // OUTPUT: 1000

        // TODO: if you don't override the method, the default behavior just prints
        // the name of the class and the namespace
            object a = new object();
            Console.WriteLine(a.ToString());
            // OUTPUT: System.Object

        // TODO: use the ToString method on the Book class
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1);
                // OUTPUT:
                //  Book: War and Peace by Leo Tolstoy
                //  Book: War and Peace by Leo Tolstoy
            Console.WriteLine(b1.ToString('B'));
            Console.WriteLine(b1.ToString('F'));
            
        }
    }
}
