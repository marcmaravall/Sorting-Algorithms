using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class MergeSort : IAlgorithm
    {
        public string Name => "Merge Sort";
        public List<int> Sort(List<int> input)
        {
            List<int> left = new List<int>(), right = new List<int>(), output = new List<int>();
            if(input.Count <= 1)
                return input;
            
            var Middle = input.Count / 2;
            for (int i = 0; i < Middle; i++)
                left.Add(input[i]);
            for (int i = Middle; i < input.Count; i++)
                right.Add(input[i]);
            left = Sort(left);
            right = Sort(right);
            if (left[left.Count-1] < right[0])
            {
                left.AddRange(right);
                return left;
            }
            output = Sort(left, right);
            return output;
        }

        private List<int> Sort(List<int> left, List<int> right)
        {
            List<int> output = new List<int>();
            int i = 0, j = 0;
            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    output.Add(left[i]);
                    i++;
                }
                else
                {
                    output.Add(right[j]);
                    j++;
                }
            }
            while (i < left.Count)
            {
                output.Add(left[i]);
                i++;
            }
            while (j < right.Count)
            {
                output.Add(right[j]);
                j++;
            }
            return output;
        }
    }
}
