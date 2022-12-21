using System;
using System.IO;

namespace puzzle1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = File.ReadAllText(".\\inputData.txt");

            string[] eachElf = numbers.Split("\n\n", StringSplitOptions.RemoveEmptyEntries);

            int[] arrayOfTotals = new int[eachElf.Length];

            for (int i = 0 ; i < arrayOfTotals.Length ; i++)
            {
                string[] calories = eachElf[i].Split("\n", StringSplitOptions.RemoveEmptyEntries);

                int total = 0;

                foreach (string c in calories)
                {
                    total += int.Parse(c);
                }

                arrayOfTotals[i] = total;
            }

            Array.Sort(arrayOfTotals);

            Console.WriteLine(arrayOfTotals[arrayOfTotals.Length - 1]);
        }
    }
}