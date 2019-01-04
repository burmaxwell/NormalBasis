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

            string a = "10111000010101000010010000111001011111011000100101101111000111011010100000111000001110001000100011001100010010100110010010111001111110110100110001111010110101001111000101000001011";
            string b = "10110010111000010111011111111111110000001000000100111101101111100010010011010011010110100000011001110110010110010000010101100110111000010011001000111110101010100110000011001010100";
            string c = "01110101110001110100010101000100100101100100110111111001111010000111100101101111000001111001100001000011010001000100101011110001110101001101111010111110110010001000011000011010001";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            Console.WriteLine(c);
            Console.WriteLine(Field.Byte_To_String(Field.BigPower(p1,p2)));

            Console.ReadKey();
        }
    }
}
