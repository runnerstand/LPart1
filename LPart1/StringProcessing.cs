using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class StringProcessing
    {
        // Public fields
        public string S;
        public int N;

        // Constructor
        public StringProcessing(string inputString, int shiftValue)
        {
            S = inputString;
            N = shiftValue;
        }

        // Simplified method to shift the string
        public string ShiftString()
        {
            string result = ""; // Start with an empty string

            foreach (char c in S) // Loop through each character
            {
                if (char.IsLetter(c)) // Only shift letters
                {
                    char start = char.IsUpper(c) ? 'A' : 'a';
                    char shiftedChar = (char)(start + (c - start + N) % 26);
                    result += shiftedChar; // Append shifted character
                }
                else
                {
                    result += c; // Keep non-letter characters unchanged
                }
            }

            return result; // Return the final shifted string
        }
    }
}