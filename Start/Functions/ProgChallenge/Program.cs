using System;
using System.Text;

namespace ProgChallenge 
{
    class IsPalindrome 
    {
        static void Main(string[] args){
            // Establish a string placeholder for each user input string
            string inputStr = "";
            // Establish a tuple to hold the result of "isPalindrome" which
            //  will have a bool of T or F, and the length of it.
            (bool val, int len) result;
            Console.WriteLine("Let's Begin: ");
            while(inputStr != "exit"){
                inputStr = Console.ReadLine();
                if(inputStr != "exit"){
                    result = isPalindrome(inputStr);
                    Console.WriteLine($"Palindrome: {result.val}, Length: {result.len}");
                }
            }
        }

        static (bool, int) isPalindrome (string str){
            // Establish a new string that is a copy of the input for testing
            string convStr; 
            // Begin by converting everything to uppercaser for consistency
            convStr = str.ToUpper();

            // Use a stringbuilder to sift out spaces and punctuation
            var strBuild = new StringBuilder();
            // FOR EACH CHARACTER in the INPUT STRING
            foreach (char c in convStr){
                // ONLY IF it is NOT punctuation and NOT a whitespace
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)){
                    // Append KG actual letters
                    strBuild.Append(c);
                }
            }
            // Once the purely letter based string is built, save back to the 
            //  conv string for testing.
            convStr = strBuild.ToString();
            // Establish initial and ending character indexes in the string
            int i = 0;               
            int j = convStr.Length-1;

            // Palidrome for a 6 letter word
            //  [0] [1] [2] [3] [4] [5] 
            //  0/5, 1/4, and 2/3 must be equal
            while(i <= j){
                // If at any point, there is a discrepancy, return false right away
                if(convStr[i] != convStr[j]){
                    return(false, 0);
                }
                i++;
                j--;
            }
            // If the above section never returns false, then we must have a palindrome
            return (true, convStr.Length);

        }
    }
}

