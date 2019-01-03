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

            string a = "10011101001011010010111010001101100110101010100000101101001001100011010111000110111001101000111011110000001000101101100111101110110101001101110011111110010100110111110011011101010";
            string b = "11101001000110000100110111001001101000101000011101010111001100100000101111001001101010000101000000111010000111100011111001100110101001110001101101001101000101100000100010001111110";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
