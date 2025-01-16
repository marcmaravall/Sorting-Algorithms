using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class RadixSort : IAlgorithm
    {
        public string Name => "Radix Sort";
        public List<int> Sort(List<int> input)
        {
            int max = input.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(input, exp);
            }
            return input;
        }

        private void CountingSort(List<int> input, int exp)
        {
            int[] count = new int[10];
            int[] output = new int[input.Count];
            for (int i = 0; i < input.Count; i++)
            {
                count[(input[i] / exp) % 10]++;
            }
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = input.Count - 1; i >= 0; i--)
            {
                output[count[(input[i] / exp) % 10] - 1] = input[i];
                count[(input[i] / exp) % 10]--;
            }
            for (int i = 0; i < input.Count; i++)
            {
                input[i] = output[i];
            }
        }
    }
}
