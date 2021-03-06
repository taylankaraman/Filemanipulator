﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // string path = "C:\\sources\\FileManipulator\\FileManipulator\\publishedWithCert.txt";
            string path = "TextFile1.txt";

            // Read the input file
            int[] numbers = readFileAndReturnIntArray(path);

            printArray(numbers);

            var uniqueNumbers = removeDuplicatesFromIntArray(numbers);

            printArray(uniqueNumbers);
        }

        
        static Array removeDuplicatesFromIntArray(int[] intArray)
        {
            return intArray.Distinct().ToArray();
        }

        static int[] readFileAndReturnIntArray(string filePath)
        {
            string line;
            int counter = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            int lineCount = File.ReadLines(filePath).Count();
            int[] intArray = new int[lineCount];

            while ((line = file.ReadLine()) != null)
            {
                intArray[counter] = Int32.Parse(line);
                counter++;
            }

            file.Close();

            return intArray;
        }


        static void printArray(Array collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }


}
