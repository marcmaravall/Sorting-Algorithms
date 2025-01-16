using System;

namespace SortingAlgorithms.Algorithms.Interfaces
{
    public interface IAlgorithm
    {
        public string Name { get; }
        public List<int> Sort(List<int> input);
    }
}
