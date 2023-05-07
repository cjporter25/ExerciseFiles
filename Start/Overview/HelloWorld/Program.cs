// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your Name?");
            try {
                string str = "default";
                if ((str = Console.ReadLine()) != null) {
                    Console.WriteLine("Why, hello there " + str);
                }
                
            } catch {
                Console.WriteLine("Please input valid characters");
            }
            
     }
  }
}


