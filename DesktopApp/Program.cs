﻿using DesktopApp.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();

            //var shirts = db.TShirts.OrderBy(x=>x.Fabric).ThenBy(x=>x.Color).ThenBy(x=>x.Size);
            var shirts = db.TShirts;
            int n = shirts.Count;
            //BubbleSort.OrderBySize(shirts);
            //shirts.BubbleSortOrderBySize();
            //shirts.BubbleSortOrderByDescendingSize();
            //shirts.BubbleSortOrderByDescendingSizeColorFabric();
            shirts.QuickSortOrderBySize(0, n - 1);
            foreach (var shirt in shirts)
            {
                shirt.Output();
            }
        }
        
    }
}
