using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class CountingSort
    {
        public static int[] countingSort(int [] arr, int min,int max)
        {
            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++) { count[i] = 0; }
            for (int i = 0; i < arr.Length; i++) { count[arr[i] - min]++; }

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    arr[z] = i;
                    z++;
                }
            }
            return arr;
        }
    }
}
