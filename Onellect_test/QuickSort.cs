using Onellect_test.Interface;

namespace Onellect_test
{
    internal class QuickSort : ISorting
    {
        public int[] Sort(int[] array)
        {
            return Sorting(array,0, array.Length-1);
        }
        int[] Sorting(int[] array,int  minIndex,  int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int p = Index(array, minIndex, maxIndex);
            Sorting(array, minIndex, p - 1);
            Sorting(array, p + 1, maxIndex);
            return array;
        }
        int Index(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }
        static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }

    }
}
