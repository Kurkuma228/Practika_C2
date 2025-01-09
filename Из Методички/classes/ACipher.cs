using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Из_Методички.interfaces;

namespace Из_Методички.classes
{
    public class ACipher : ICipher
    {
        public string Encode(string input)
        {
            return Shift(input, 1);
        }

        public string Decode(string input)
        {
            return Shift(input, -1);
        }

        private string Shift(string input, int shift)
        {
            char ShiftChar(char c, int shiftValue)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'А' : 'а';
                    return (char)((((c - offset) + shiftValue + 32) % 32) + offset);
                }
                return c;
            }

            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ShiftChar(result[i], shift);
            }

            return new string(result);
        }
    }

}
