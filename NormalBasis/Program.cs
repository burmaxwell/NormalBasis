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

            string a = "01000111100101010001010011000110000101100101011100110110011100101101101010110000010000000010000000101100000110110001111000011001001001111001110110111001010010000100110100100111011";
            string b = "10110010111000010111011111111111110000001000000100111101101111100010010011010011010110100000011001110110010110010000010101100110111000010011001000111110101010100110000011001010100";
            string c = "10000111110110101011000110100001100010111010001101010100100010010110101101110011001101010010101001010001110110000100010001110101011011101100011101011011110111011001110111100101001";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            Console.WriteLine(c);
            Console.WriteLine(Field.Byte_To_String(Field.Inverse(p1)));

            Console.ReadKey();
        }
    }
}
