using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace decompose
{
    class Program
    {
        static void Main(string[] args)
        {
            // long n = 11;
            long n = 50;
            decompose(n);
        }

        public static string decompose(long n)
        {
            String result = null;

            for (long i = n - 1; i > 1; i--)
            {
                long square = n * n;
                result = recurseDecompose(i, square);
                if (result != null) break;
            }
            WriteLine(result);

            return result;
        }

        public static String recurseDecompose(long i, long rem)
        {
            if (i * i == rem)
            {
                return i + "";
            }
            else if (i * i < rem)
            {
                rem = rem - i * i;

                for (long j = i - 1; j > 0; j--)
                {
                    String tmp = recurseDecompose(j, rem);

                    if (tmp != null)
                    {
                        return tmp + " " + i;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                return null;
            }

            return null;
        }


    }
}
