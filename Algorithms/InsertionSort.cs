using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class InsertionSort : IAlgorithm
    {
        public String Name => "Insertion Sort";
        public List<int> Sort(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                int key = input[i];
                int j = i - 1;
                while (j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j -= 1;
                }
                input[j + 1] = key;
            }
            return input;
        }
    }
}
