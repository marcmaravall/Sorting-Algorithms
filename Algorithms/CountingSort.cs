using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class CountingSort : IAlgorithm
    {
        public string Name => "Counting Sort";
        public List<int> Sort(List<int> input)
        {
            int max = input.Max();
            int[] count = new int[max + 1];
            int[] output = new int[input.Count];
            for (int i = 0; i < input.Count; i++)
            {
                count[input[i]]++;
            }
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = input.Count - 1; i >= 0; i--)
            {
                output[count[input[i]] - 1] = input[i];
                count[input[i]]--;
            }
            for (int i = 0; i < input.Count; i++)
            {
                input[i] = output[i];
            }
            return input;
        }
    }
}
