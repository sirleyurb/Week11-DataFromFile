using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your zodiac sign:");
            string userZodiacSign = Console.ReadLine();

            string output = GetLineFromfileData(userZodiacSign);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry. Zodiac sign not found.");
            }

            static string[] ReadDataFromFile()
            {
                string directoryPath = @"C:\Users\opilane\samples";
                string fileName = "horoscope.txt";
                string fullPath = $@"{directoryPath}\{fileName}";

                string[] dataFromFile = File.ReadAllLines(fullPath);

                return dataFromFile;
            }

            static string GetLineFromfileData(string userInput)
            {
                string[] dataFromFile = ReadDataFromFile();
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
}
