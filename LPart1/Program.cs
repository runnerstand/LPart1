using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter a shift value: ");
            int shiftValue = int.Parse(Console.ReadLine());

            // Object creation
            StringProcessing processing = new StringProcessing(inputString, shiftValue);

            //Call Print method
            processing.Print();

            //Call outputCode method and display the ASCII values
            int[] asciiValues = processing.OutputCode();
            Console.WriteLine("ASCII values: ");
            foreach (int value in asciiValues)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            processing.InputCode();
            processing.Print();
        }
    }
}