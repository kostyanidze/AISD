using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ChangeEvent
    {
        public static void choose(int n, int[] f,int[] l)
        {
            int i, j;
            i = 0;
            Console.Write(i + " ");
            for (j = 1; j < n; j++)
            {
                if (f[j] >= l[i])
                {
                    Console.Write(j + " ");
                    i = j;
                }
            }
            Console.WriteLine();
        }
    }
}
