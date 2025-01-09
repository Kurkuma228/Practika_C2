using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Методички.interfaces
{
    internal interface ICipher
    {
        string Encode(string code);
        string Decode(string code);
    }
}
