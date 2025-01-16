using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class SelectionSort : IAlgorithm
    {
        public string Name => "Selection Sort";
        public List<int> Sort(List<int> input)
        {
            for (int i = 0; i < input.Count-1; i++)
            {
                int min = i;
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[j] < input[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = input[i];
                    input[i] = input[min];
                    input[min] = temp;
                }
            }
            return input;
        }
    }
}
