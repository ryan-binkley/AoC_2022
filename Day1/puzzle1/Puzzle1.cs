using System;
using System.IO;

namespace puzzle1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.OpenRead(".\\inputData.txt");

            StreamReader sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadLine());
        }
    }
}