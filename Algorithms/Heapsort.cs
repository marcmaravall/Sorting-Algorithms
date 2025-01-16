using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class Heapsort : IAlgorithm
    {
        public string Name => "Heapsort";

        public List<int> Sort(List<int> input)
        {
            int n = input.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(input, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = input[0];
                input[0] = input[i];
                input[i] = temp;

                Heapify(input, i, 0);
            }

            return input;
        }

        void Heapify(List<int> arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }
    }
}