using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Из_Методички.interfaces;

namespace Из_Методички.classes
{
    public class BCipher : ICipher
    {
        public string Encode(string input)
        {
            return ReplaceWithReverse(input);
        }

        public string Decode(string input)
        {
            return ReplaceWithReverse(input);
        }

        private string ReplaceWithReverse(string input)
        {
            char ReplaceChar(char c)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'А' : 'а';
                    return (char)(offset + ('Я' - c));
                }
                return c;
            }

            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ReplaceChar(result[i]);
            }

            return new string(result);
        }
    }
}
