using SortingAlgorithms.Algorithms;
using SortingAlgorithms.Algorithms.Interfaces;

IAlgorithm sort = new BogoSort();
List<int> input = new List<int> { 5, 3, 2, 8, 4, 2, 10 };
Console.WriteLine(sort.Name);
foreach (var i in sort.Sort(input))
{
    Console.WriteLine(i);
}