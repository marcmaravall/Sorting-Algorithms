using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class BucketSort : IAlgorithm
    {
        public string Name => "Bucket Sort";

        public List<int> Sort(List<int> input)
        {
            if (input == null || input.Count == 0)
                return input;

            int minValue = input.Min();
            int maxValue = input.Max();
            int bucketCount = maxValue - minValue + 1;

            List<int>[] buckets = new List<int>[bucketCount];

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
            }

            foreach (int num in input)
            {
                int bucketIndex = num - minValue;
                buckets[bucketIndex].Add(num);
            }

            List<int> sortedList = new List<int>();

            foreach (var bucket in buckets)
            {
                if (bucket.Count > 0)
                {
                    bucket.Sort();
                    sortedList.AddRange(bucket);
                }
            }

            return sortedList;
        }
    }
}