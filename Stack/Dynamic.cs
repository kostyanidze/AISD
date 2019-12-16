using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Dynamic
    {
        private static int sequence(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

          
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }


        private static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public static void check(string inStr, string subStr)
        {
            char[] X = inStr.ToCharArray();
            char[] Y = subStr.ToCharArray();

            int m = X.Length;
            int n = Y.Length;
            Console.WriteLine("The longest sequence :{0} symbols", sequence(X, Y, m, n));
        }
    }
}
