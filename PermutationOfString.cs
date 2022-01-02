using System;

/*
1. Write static functions to return all permutations of a String using iterative method and
Recursion method. Check if the arrays returned by two string functions are equal.
*/

namespace PermutationsOfString
{
    internal class PermutationOfString
    {
        // Iterative Method
        static void permutation(String s, String answer)
        {
            if (s.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                String left_substr = s.Substring(0, i);
                String right_substr = s.Substring(i + 1);
                String rest = left_substr + right_substr;
                permutation(rest, answer + ch);
            }
        }

        // Recursive Method
        /*
        * permutation function @param str string to calculate permutation for
        * @param l starting index @param r end index
        */
        private static void permute(String str,
                                    int l, int r)
        {
            if (l == r)
                Console.Write(str + " ");
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        /*
        * Swap Characters at position @param a string value
        * @param i position 1 @param j position 2 @return swapped string
        */
        public static String swap(String a,
                                int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        static void Main(string[] args)
        {
            // Iterative Method
            String s;
            String answer = "";

            Console.Write("Enter the string : ");
            s = Console.ReadLine();

            Console.Write("\nAll possible strings are : ");
            permutation(s, answer);
            Console.WriteLine("\n###### End of Iterative Method ######\n");

            // Recursive Method
            Console.WriteLine("Permutation of given string by Recursive Method is: ");
            String str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
            Console.WriteLine();
        }
    }
}
