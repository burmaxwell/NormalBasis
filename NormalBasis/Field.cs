﻿using System;
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

                    if ( (((pow_i - pow_j) + p) % p) == 1 || ((pow_i + pow_j) % p) == 1 || (((-pow_i - pow_j) + p) % p) == 1 || ((pow_j - pow_i + p) % p) == 1)

                    {
                        Matrix[i,j] = 1;
                        continue;
                    }

                    Matrix[i,j] = 0;
                }
            }
            return Matrix;
        }
        
        public static int[] Mul(int[] a, int[] b)
        {
            int[] result = new int[a.Length];
            int[,] Matrix =LambdaMatrix(a.Length);

            for (int n = 0; n < a.Length; n++)
            {          
                int[] temp = new int[a.Length];

                for (int j = 0; j < a.Length; j++)
                {
                    for (int i = 0; i < a.Length; i++)
                        temp[j] = (temp[j]) ^ (a[i] & Matrix[i,j]);                    
                }

                int matrix_element = 0;

                for (int i = 0; i < a.Length; i++)
                    matrix_element = (matrix_element) ^ (temp[i] & b[i]);


                result[n] = matrix_element;
                a = ShiftBitToLeft(a);
                b = ShiftBitToLeft(b);
            }

            return result;
        }

        public static int[] BigPower(int[]a,int[]n)
        {
            int[] result = new int[a.Length];
            string one = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            result = String_To_Byte(one);

            for (var i = a.Length - 1; i >= 0; i--)
            {
                if (n[i] == 1)
                {
                    result = Mul(result, a);
                }
                a = ShiftBitToRight(a);
            }
            return result;
        }

        public static int[] beta2k(int[] a, int k)
        {
            int[] Beta = new int[a.Length];
            Beta = a;
            for (int i = 1; i <= k; i++)
            {
                Beta=ShiftBitToRight(Beta);
            }
            return Beta;
        }

        public static int[] Inverse(int[] a)
        {  
            
            string a_len_in_binary = "10110010";//m=m-1=179-1=178 in binary
            int[] m_in_binary = new int[a_len_in_binary.Length];
            m_in_binary = String_To_Byte(a_len_in_binary);

            int k = 1;
            int[] beta = new int[a.Length];
            beta = a;

            for (int i = 1; i < a_len_in_binary.Length; i++)
            {
                beta = Mul(beta2k(beta, k), beta);
                k = 2*k;
                if (m_in_binary[i] == 1)
                {
                    beta = Mul(ShiftBitToRight(beta),a);
                    k = k + 1;
                }
            }
            beta = ShiftBitToRight(beta);
            return beta;
        }

    }
}
