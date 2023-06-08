using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some publications
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825, 39.95m);
            Magazine m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

            Console.WriteLine($"{b1.Name}, {b1.Author}");
            Console.WriteLine($"{m1.Name}, {m1.Publisher}");
            // OUTPUT:
            // War and Peace, Leo Tolstoy
            // Time, Time USA, LLC

        // Property validation logic will prevent an empty name
            // b1.Name = "";

            // Call the override functions
             Console.WriteLine(b1.GetDescription());
             Console.WriteLine(b1.Price);
             Console.WriteLine(m1.GetDescription());
             Console.WriteLine(m1.Price);

            // OUTPUT: Book has the "GetDescription" method overwritten, magazine does not
            // War and Peace by Leo Tolstoy, 825 pages
            // 39.95
            // Time, 75 pages
            // 4.95
        }
    }
}
