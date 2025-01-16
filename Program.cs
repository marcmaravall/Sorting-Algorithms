using SortingAlgorithms.Algorithms;
using SortingAlgorithms.Algorithms.Interfaces;

IAlgorithm[] algorithms = new IAlgorithm[]
{
    new BogoSort(),
    new BubbleSort(),
    new BucketSort(),
    new SelectionSort(),
    new CountingSort(),
    new MergeSort(),
    new Quicksort(),
    new RadixSort(),
    new InsertionSort(),
    new Heapsort()
};

List<int> input = new List<int> { 5, 3, 2, 8, 4, 2, 10 };

Console.Write("Input: ");
foreach (var i in input)
    Console.Write(i + ", ");
Console.WriteLine();

foreach (IAlgorithm i in algorithms)
{
    Console.Write(i.Name+"  ");
    foreach (var j in i.Sort(input))
        Console.Write(j + ", ");
    Console.WriteLine();
}
