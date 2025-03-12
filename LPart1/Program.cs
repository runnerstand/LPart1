using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
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

            // Display stored values
            Console.WriteLine($"Stored String: {processing.S}");
            Console.WriteLine($"Stored Shift Value: {processing.N}");

            // Call the ShiftString() method and display result
            string shiftedString = processing.ShiftString();
            Console.WriteLine($"Shifted String: {shiftedString}");
        }
    }
}