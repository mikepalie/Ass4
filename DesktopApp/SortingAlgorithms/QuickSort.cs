using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopApp.SortingAlgorithms
{
    public static class QuickSort
    {

        public static void QuickSortOrderBySize(this List<TShirt> shirts, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(shirts, left, right);

                QuickSortOrderBySize(shirts, left, pivot - 1);
                QuickSortOrderBySize(shirts, pivot + 1, right);
            }
        }

        public static int Partition(List<TShirt> shirts, int left, int right)
        {
            TShirt pivot = shirts[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (shirts[j].Size <= pivot.Size)
                {
                    i++;
                    TShirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }

            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[right];
            shirts[right] = temp1;

            return i + 1;
        }



    }
} 


