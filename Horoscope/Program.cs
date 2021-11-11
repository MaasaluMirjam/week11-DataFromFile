using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope:");
            string userSign = Console.ReadLine();
           
            string output = GetHoroscope(userSign);
            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry, your zodic sign not found.");
            }
        }
        private static string[] ReadHoroscope()
        {
            string directoryPath = @"C:\Users\opilane\samples";
            string fileName = "horoscope.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            return dataFromFile;
        }
        private static string GetHoroscope(string userInput)
        {
            string[] dataFromFile = ReadHoroscope();
            string result = "";

            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }
    }
}
