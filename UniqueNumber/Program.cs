using System;
using System.Collections.Generic;
namespace UniqueNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 4, 3, 6, 3, 6 };
            int uniqueNumber = FindNumber(Numbers);
            if (uniqueNumber != 0)
            {
                Console.Write("Số duy nhất trong mảng là: " + uniqueNumber);
            }
            else
            {
                Console.Write("Null");
            }
        }
        static int FindNumber(int[] Numbers)
        {
            HashSet<int> unique = new HashSet<int>();
            HashSet<int> repeat = new HashSet<int>();
            foreach (int number in Numbers)
            {
                if (!unique.Add(number))
                {
                    unique.Remove(number);
                    repeat.Add(number);
                }
                else if (!repeat.Contains(number))
                {
                    unique.Add(number);
                }
            }
            foreach (int uniqueNumber in unique)
            {
                return uniqueNumber;
            }
            return 0;
        }
    }
}