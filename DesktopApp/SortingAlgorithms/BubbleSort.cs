using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void BubbleSortOrderBySize(this List<TShirt> shirts)
        {
            TShirt temp;
            int size = shirts.Count - 2;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void BubbleSortOrderByDescendingSize(this List<TShirt> shirts)
        {
            TShirt temp;
            int size = shirts.Count - 2;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void BubbleSortOrderBySizeColorFabric(this List<TShirt> shirts)
        {
            TShirt temp;
            int size = shirts.Count - 2;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Color > shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void BubbleSortOrderByDescendingSizeColorFabric(this List<TShirt> shirts)
        {
            TShirt temp;
            int size = shirts.Count - 2;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Color < shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

    }
}
