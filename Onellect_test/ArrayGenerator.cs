using Onellect_test.Interface;

namespace Onellect_test
{
    internal class ArrayGenerator : IGenerate
    {
        public int[] Generate(int minValue, int maxValue)
        {
            Random random = new Random();
            int[] result = new int[random.Next(20,100)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(minValue, maxValue);
            }
            return result;
        }

    }
}
