using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

        // TODO: the basic for loop
            Console.WriteLine("The basic for loop:");
            for (int i = 0; i < myVal; i++) {
                Console.WriteLine("i is currently {0}", i);
            }
            Console.WriteLine();

        // TODO: the foreach-in loop can be used to iterate over sequences
            // For each integer in the array "nums", print it out
            foreach (int i in nums) {
                Console.WriteLine("i is currently {0}", i);
            }

        // TODO: count the number of o's in the string
            var count = 0;
            // Check each character in a string
            foreach (char c in str) {
                if (c == 'o') {
                    count++;
                }
            }
            Console.WriteLine("Counted {0} o characters", count);


        }
    }
}
