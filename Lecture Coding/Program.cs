using Lecture_Coding.Midterm;

namespace Lecture_Coding;

public class Program
{
    private static readonly int[] SortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private static readonly int[] UnsortedArray = { 5, 10, 3, 18, 2, 5, 7, 12 };
    private static readonly int[] UnsortedHeapArray = { 73, 57, 49, 99, 133, 20, 1 };

    public static void Main(string[] args)
    {
        if (args == null) throw new ArgumentNullException(nameof(args));

        // Binary Search
        // Console.WriteLine(new BinarySearch().Search(SortedArray, 15));
        // Console.WriteLine(new BinarySearch().BSearch(SortedArray, 11));

        // Quick Sort
        // Console.WriteLine("Insertion sort: [{0}]", string.Join(", ", new Sorting().InsertionSort(UnsortedArray)));
        // Console.WriteLine("Selection sort: [{0}]", string.Join(", ", new Sorting().SelectionSort(UnsortedArray)));
        // Console.WriteLine("Quick sort: [{0}]", string.Join(", ", new Sorting().QuickSort(UnsortedArray, 1, UnsortedArray.Length)));

        // Linear Sort
        // Console.WriteLine("Counting sort: [{0}]", string.Join(", ", new LinearSort().CountingSort(UnsortedArray)));
        // Console.WriteLine("Radix counting sort: [{0}]", string.Join(", ", new LinearSort().RadixSort(UnsortedArray)));
        // Console.WriteLine("Bucket sort: [{0}]", string.Join(", ", new LinearSort().BucketSort(UnsortedArray)));

        // Heap Sort
        Console.WriteLine("Heap sort: [{0}]", string.Join(", ", new HeapSort().Sort(UnsortedHeapArray, UnsortedHeapArray.Length)));
    }
}
