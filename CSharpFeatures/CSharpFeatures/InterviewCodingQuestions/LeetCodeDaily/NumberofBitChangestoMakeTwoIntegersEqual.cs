using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class NumberofBitChangestoMakeTwoIntegersEqual
    {
        public static int MinimumChanges(int n, int k)
        {
            if (n != 0 && k != 0)
            {
                if (n == k)
                {
                    return 0;
                }


                //string nBits = GetBinaryRepresentation(n);
                //string kBits = GetBinaryRepresentation(k);

                //int nLength = nBits.Length;
                //int kLength = kBits.Length;
                //int size = nLength > kLength ? nLength : kLength;

                //for (int i = size; i >= 0; i--)
                //{

                //}

                int l = n - k;
                string nBits = Convert.ToString(n, 2);
                string lBits = Convert.ToString(l, 2);

                if (lBits == "1")
                {
                    return -1;
                }
                int nCount = 0;
                int lCount = 0;

                for (int i = 0; i < nBits.Length; i++)
                {
                    if (nBits[i] == '1')
                    {
                        nCount++;
                    }

                    if (lBits.Length >= i)
                    {
                        if (lBits[i] == '1')
                        {
                            lCount++;
                        }
                    }


                }

                if (lCount == nCount)
                {
                    return -1;
                }
                else
                {
                    return lCount;
                }


            }
            return 0;
        }

        static string GetBinaryRepresentation(int number)
        {
            // Assuming we are dealing with 32-bit integers
            int size = sizeof(int) * 8; // 32 bits
            char[] bits = new char[size];

            for (int i = 0; i < size; i++)
            {
                // Use bitwise AND and shift to get the bit at position i
                bits[size - 1 - i] = (number & (1 << i)) != 0 ? '1' : '0';
            }

            // Join the array into a string and trim leading zeros
            return new string(bits).TrimStart('0');
        }



        public static int MinChanges(int n, int k)
        {
            if ((k & ~n) != 0)
            {
                return -1;
            }

            int changes = 0;

            // Loop through each bit
            for (int i = 0; i < 32; i++)
            {
                int nBit = (n >> i) & 1;
                int kBit = (k >> i) & 1;

                // If n has a bit set to 1 and k has a bit set to 0, we need to change this bit
                if (nBit == 1 && kBit == 0)
                {
                    changes++;
                }
            }

            return changes;
        }
    }
}
