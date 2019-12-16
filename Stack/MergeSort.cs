using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MergeSort
{    

   public static int[] MergeSorting(int[] array, int start, int end)
   {
        
        if (end - start < 2)
            return new int[] { array[start] };

        int middle = start + ((end - start) / 2);
        int[] left = MergeSorting(array, start, middle);
        int[] right = MergeSorting(array, middle, end);

       
        int[] result = new int[left.Length + right.Length];

        int idxL = 0;
        int idxR = 0;
        int i = 0;

        for (; idxL < left.Length && idxR < right.Length; i++)
        {
            if (left[idxL] < right[idxR])
            {
                result[i] = left[idxL];
                idxL++;
            }
            else
            {
                result[i] = right[idxR];
                idxR++;
            }
        }

      
        while  (idxL < left.Length)
            result[i++] = left[idxL++];

        while (idxR < right.Length)
            result[i++] = right[idxR++];


        return result;
        
    }
}

