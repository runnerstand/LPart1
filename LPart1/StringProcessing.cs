using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPart1
{
    class StringProcessing
    {
        // Private fields
        private string s;
        private int n;

        // Public properties with validation
        public string S
        {
            get { return s; }
            set
            {
                // Ensure only capital letters (A-Z) are allowed
                if (!string.IsNullOrEmpty(value) && value.All(char.IsUpper))
                {
                    s = value;
                }
                else
                {
                    Console.WriteLine("Invalid input! String must contain only capital letters (A-Z).");
                    s = "DEFAULT"; // Set to a default value if invalid
                }
            }
        }

        public int N
        {
            get { return n; }
            set
            {
                // Ensure shift value is within the range -25 to 25
                if (value >= -25 && value <= 25)
                {
                    n = value;
                }
                else
                {
                    Console.WriteLine("Invalid shift value! Setting to 0.");
                    n = 0; // Default to 0 if out of range
                }
            }
        }

        // Constructor (Uses properties for validation)
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

        // InputCode Method (Now uses properties)
        public void InputCode()
        {
            Console.Write("Enter a new string: ");
            S = Console.ReadLine();

            int value;
            while (true)
            {
                Console.Write("Enter a new shift value: ");
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    N = value;
                    break;
                }
                Console.WriteLine("Invalid input! Please enter a number between -25 and 25.");
            }
        }

        // OutputCode Method (Returns ASCII values of each character in S)
        public int[] OutputCode()
        {
            int[] asciiValues = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                asciiValues[i] = (int)S[i];
            }

            return asciiValues;
        }

        // Sort Method
        public string Sort()
        {
            char[] charArray = S.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }

        // Encode Method
        public string Encode()
        {
            char[] result = S.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char start = char.IsUpper(result[i]) ? 'A' : 'a';
                    result[i] = (char)(start + (result[i] - start + N + 26) % 26);
                }
            }

            return new string(result);
        }
    }
}
