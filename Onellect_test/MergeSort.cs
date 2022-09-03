using Onellect_test.Interface;

namespace Onellect_test
{
    internal class MergeSort : ISorting
    {
        public int[] Sort(int[] array)
        {
            if (array.Length == 1)
                return array;
            int middle = array.Length / 2;
            return merge(Sort(array.Take(middle).ToArray()), Sort(array.Skip(middle).ToArray()));
        }
        public int[] merge(int[] arr1, int[] arr2)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length];
            for (Int32 i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }
            return merged;
        }
    }
}
