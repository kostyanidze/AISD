﻿using System;

public static class InsertSort
    {
        public static int[] InsertionSort(int[] array)
        {

            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > array[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = array[i];
            }
            return result;
        }
 }
