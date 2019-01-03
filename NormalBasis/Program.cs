using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalBasis
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "1001111";
            string b = "011000";
            string c = "0000000000000";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            Console.WriteLine(Field.Byte_To_String(Field.ShiftBitToLeft(p1)));
            Console.WriteLine((Field.Trace(p2)));
            Console.WriteLine((Field.Trace(p3)));

            Console.ReadKey();
        }
    }
}
