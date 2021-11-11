using System;
using System.IO;

namespace Chuck
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(RandomLineFromFile());
            }           
        }

        private static string RandomLineFromFile()
        {          
            string filePath = @"C:\Users\opilane\samples\chuck.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, dataFromFile.Length);

            return dataFromFile[randomIndex];
        }
    }
}
