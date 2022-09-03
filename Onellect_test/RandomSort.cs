using Onellect_test.Interface;

namespace Onellect_test
{
    internal class RandomSort
    {
        MergeSort mergeSort;
        QuickSort quickSort;
        Random random = new Random();
        public ISorting Random()
        {
            if(random.Next(100) <= 50 ? true : false)
            {
                return mergeSort = new MergeSort();
            }
            else
            {
                return quickSort = new QuickSort();
            }
        }
    }
}
