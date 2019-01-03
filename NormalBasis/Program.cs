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

            string a = "10100111";
            string b = "11101001";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            Console.WriteLine(Field.Byte_To_String(Field.ShiftBitsToRight(p1,2)));
            Console.ReadKey();
        }
    }
}
