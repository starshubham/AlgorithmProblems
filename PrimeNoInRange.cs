using System;


namespace AnagramDetectionAndPrimeNumber
{
    public class PrimeNoInRange
    {
        public void PrintPrime()
        {
            Console.WriteLine("Enter the range: ");
            Console.Write("Enter First range value: ");
            int Low = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second range value: ");
            int High = int.Parse(Console.ReadLine());
            if (Low > High)
            {

                int temp = Low;
                Low = High;
                High = temp;
            }
            for (int i = Low; i <= High; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public bool IsPrime(int num)
        {
            
            bool flag = true;
            
            for (int i = 2; i <= num / 2; i++)
            {               
                if (num % i == 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
