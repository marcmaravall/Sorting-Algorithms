using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class BubbleSort : IAlgorithm
    {
        public string Name => "Bubble Sort";
        public List<int> Sort(List<int> input)
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = 0; j < input.Count - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }
    }
}
