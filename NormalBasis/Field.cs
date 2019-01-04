using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalBasis
{
    class Field
    {
        public static int[] String_To_Byte(string stringbitvector)
        {
            var bitlenth = stringbitvector.Length;
            int[] number = new int[bitlenth];

            for (var i = 0; i < stringbitvector.Length; i++)
            {
                number[stringbitvector.Length - 1 - i] = Convert.ToByte(stringbitvector.Substring(stringbitvector.Length - (i + 1), 1), 2);
            }

            return number;
        }

        public static string Byte_To_String(int[] bitvector)
        {
            StringBuilder stringline = new StringBuilder();

            for (int i = 0; i< bitvector.Length; i++)
            {
                stringline.Append(Convert.ToString(bitvector[i], 2));
            }

            return stringline.ToString();
        }

        public static int[] Add(int[] a, int[] b)
        {
            var maxlenght = Math.Max(a.Length, b.Length);

            Array.Resize(ref a, maxlenght);
            Array.Resize(ref b, maxlenght);
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = (a[i] ^ b[i]);
            }

            return result;
        }

        public static int[] ShiftBitsToRight(int[]a,int step)
        {
            int[] result = new int[a.Length];
            int[] temp = new int[step];

            for(int i=step-1;i>=0;i--)
            {
                temp[i] = a[a.Length - 1 - (step -1 - i)];
            }

            for(int i=a.Length-1;i>=step;i--)
            {
                result[i] = a[i - step];
            }

            for(int i=0;i<step;i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        public static int[] ShiftBitToRight(int[] a)// Square
        {
            int[] result = new int[a.Length];
            for (int i = 0; i < a.Length-1; i++)
            {
                result[i + 1] = a[i];
            }
            result[0] = a[a.Length-1];
            return result;
        }

        public static int Trace(int[]a)
        {
            int trace =0;
            for (int i = 0; i < a.Length; i++)
                trace = trace ^ a[i];
            return trace;
        }

        public static int[] ShiftBitToLeft(int[] a)
        {
            int[] result = new int[a.Length];
            for (int i = 1; i < a.Length ; i++)
            {
                result[i - 1] = a[i];
            }
            result[a.Length-1] = a[0];
            return result;
        }

        public static int[,] LambdaMatrix(int m)
        {
            int p = 2 * m + 1;
            int[,] Matrix = new int[m,m];
            int[] pow_two_mod_p = new int[m];
            pow_two_mod_p[0] = 1;

            for (int i = 1; i < m; i++)
            pow_two_mod_p[i] = (pow_two_mod_p[i - 1]*2) % p;
            
            int pow_i, pow_j;

            for (int i = 0; i < m; i++)
            {
                pow_i = pow_two_mod_p[i];

                for (int j = 0; j < m; j++)
                {
                    pow_j = pow_two_mod_p[j];

                    if (((pow_i + pow_j) % p) == 1 || (((pow_i - pow_j) + p) % p) == 1 || ((pow_j - pow_i + p) % p) == 1 || (((-pow_i - pow_j) + p) % p) == 1)

                    {
                        Matrix[i,j] = 1;
                        continue;
                    }

                    Matrix[i,j] = 0;
                }
            }

            return Matrix;
        }



















    }
}
