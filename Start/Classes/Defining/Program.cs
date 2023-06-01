using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
        // Creating a new object instances using the "new" operator
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The Grapes of Wrath", "John Steinback", 464);
        // Calling a method on an object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());


        // Try to set one of the properties -- this will result in an error
            //b1._name = "Aldous Huxley";

        }
    }
}
