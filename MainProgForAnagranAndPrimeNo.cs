using System;

namespace AnagramDetectionAndPrimeNumber
{
    internal class MainProgForAnagranAndPrimeNo
    {
        static void Main(string[] args)
        {
            // Q1. Anagram Detection
            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            AnagramDetection anagram = new AnagramDetection();
            //Check if words are anagram  
            if (anagram.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");
            }
            Console.WriteLine("\n***********End of Question1***********\n");


            // Q2. Find Prime number in Range
            PrimeNoInRange primeRange = new PrimeNoInRange();
            Console.WriteLine("Find Prime numbers between given range : ");
            primeRange.PrintPrime();
            Console.WriteLine("\n***********End of Question2***********\n");


            // Q3. find the prime numbers that are Anagram and Palindrome
            CheckPrimePalindromeAndAnagram obj = new CheckPrimePalindromeAndAnagram();
            Console.WriteLine("Prime numbers that are Anagram and Palindrome");
            obj.PrintPrime1();
            Console.WriteLine("\n***********End of Question3***********\n");
        }
    }
}
