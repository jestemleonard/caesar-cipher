using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caesar
{
    class Program
    {
        static char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        public static string Encrypt(string input, int key)
        {
            string output = string.Empty;
            input = input.ToLower();
            foreach (char ch in input)
            {
                for(int i = 0; i < 34; i++)
                    if (ch == alphabet[i])
                        output += alphabet[(i + key) % 34];
            }

            return output;
        }

        public static string Decrypt(string input, int key)
        {
            string output = string.Empty;
            input = input.ToLower();
            foreach (char ch in input)
            {
                for (int i = 0; i < 34; i++)
                    if (ch == alphabet[i])
                    {
                        int absoluteValue = Math.Abs(i - key);
                        output += alphabet[(absoluteValue) % 34];
                    }
            }

            return output;
        }
    }
}
