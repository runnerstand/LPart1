using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPart1
{
    class StringProcessing
    {
        // Public fielders
        public string S;
        public int N;

        // Constructor
        public StringProcessing(string inputString, int shiftValue)
        {
            S = inputString;
            N = shiftValue;
        }

        // Print Method
        public void Print()
        {
            Console.WriteLine($"Stored String: {S}");
            Console.WriteLine($"Stored Shift Value: {N}");
        }

        // InputCode Method (Updates S and N with new values)
        public void InputCode()
        {
            Console.Write("Enter a new string: ");
            S = Console.ReadLine();

            Console.Write("Enter a new shift value: ");
            N = int.Parse(Console.ReadLine());
        }

        // OutputCode Method (Returns ASCII values of each character in S)
        public int[] OutputCode()
        {
            int[] asciiValues = new int[S.Length]; // Create an array to store ASCII values

            for (int i = 0; i < S.Length; i++)
            {
                asciiValues[i] = (int)S[i]; // Convert each character to ASCII
            }

            return asciiValues; // Return the array
        }
    }
}