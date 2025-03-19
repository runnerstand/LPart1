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
            // Input fields
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter a shift value: ");
            int shiftValue = int.Parse(Console.ReadLine());

            // Object creation
            StringProcessing processing = new StringProcessing(inputString, shiftValue);

            // Call Print method
            processing.Print();

            // Call OutputCode method and display the ASCII values
            int[] asciiValues = processing.OutputCode();
            Console.WriteLine("ASCII values: ");
            foreach (int value in asciiValues)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine(); // Move to the next line

            // Call Sort() method and display the sorted string
            string sortedString = processing.Sort();
            Console.WriteLine($"Sorted String: {sortedString}");

            // Call Encode() method and display the encoded string
            string encodedString = processing.Encode();
            Console.WriteLine($"Encoded String: {encodedString}");

            // Call InputCode method
            processing.InputCode();
            processing.Print();
        }
    }
}
