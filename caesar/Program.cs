using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caesar
{
    class Program
    {
        static char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        public static string Encrypt(string input, int key)
        {
            string output = string.Empty;
            input = input.ToLower();
            foreach (char ch in input)
            {
                for(int i = 0; i < 35; i++)
                    if (ch == alphabet[i])
                        output += alphabet[((i + key) % 35)];
            }

            return output;
        }

        public static string Decrypt(string input, int key)
        {
            string output = string.Empty;
            input = input.ToLower();
            foreach (char ch in input)
            {
                for (int i = 0; i < 35; i++)
                    if (ch == alphabet[i])
                    {
                        int value = i - (key % 35);
                        if (value < 0)
                            output += alphabet[35 + value];
                        else
                            output += alphabet[value];
                    }
            }

            return output;
        }
    }
}
