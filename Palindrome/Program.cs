using System;

namespace Palindrome
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Check for a PALINDROME - Enter your string - ");

            string inputString = Console.ReadLine();

            bool isPalindrome = IsPalindrome(inputString);

            Console.WriteLine(isPalindrome);

            Console.ReadLine();
        }

        // TODO: Create a method that recognizes palindromes.
        /// <summary>
        /// Check input string - is it a PALINDROME - same backwards as forwards
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>true - it is a Palindrome
        /// Fals - it is NOT a Palindrome</returns>
        public static bool IsPalindrome(string inputString)
        {
            inputString = inputString.ToUpper();

            char[] inputCharArray = inputString.ToCharArray();
            char[] reversedCharArray = new char[inputCharArray.Length];

            int reversedCharArrayIndex = 0;

            for (int i = inputCharArray.Length - 1; i >= 0; i--)
            {
                reversedCharArray[reversedCharArrayIndex] = inputCharArray[i];
                reversedCharArrayIndex++;
            }

            string reversedString = new string(reversedCharArray);

            if (inputString == reversedString)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
