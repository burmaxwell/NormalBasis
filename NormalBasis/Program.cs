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

            string a = "11001011011011011100011001101110111001100001000101110111100110110111101111001001111001011000001101101101011101010100111101111010100101000001100001011111010111001101110111110010010";
            string b = "11101011000000110101101101010001001110010000011100001111110111011100110011000001001110100110001011001010101001100000110011100101000101110101001100110000011111101011000000000111001";
            string c = "00101101011101010110001001101001100000110010000000010100101101001010000001010001101111000000000110001011011011101100001010110001100000101101101111000011110101001101010010111010000";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            Console.WriteLine(c);
            Console.WriteLine(Field.Byte_To_String(Field.Mul(p1,p2)));
            //Console.WriteLine((Field.LambdaMatrix(179)));
            //Console.WriteLine((Field.Trace(p3)));

            Console.ReadKey();
        }
    }
}
