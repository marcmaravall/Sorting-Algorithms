using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class Quicksort : IAlgorithm
    {
        public string Name => "Quicksort";
        public List<int> Sort(List<int> input)
        {
            return QuickSort(input, 0, input.Count - 1);
        }

        private List<int> QuickSort(List<int> input, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(input, low, high);
                QuickSort(input, low, pi - 1);
                QuickSort(input, pi + 1, high);
            }
            return input;
        }

        private int Partition(List<int> input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (input[j] < pivot)
                {
                    i++;
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
            int temp2 = input[i + 1];
            input[i + 1] = input[high];
            input[high] = temp2;
            return i + 1;
        }
    }
}
