namespace Lecture_Coding;

public class Program
{
    private static readonly int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public static void Main(string[] args)
    {
        if (args == null) throw new ArgumentNullException(nameof(args));

        Console.WriteLine(new BinarySearch().Search(Array, 15));
        Console.WriteLine(new BinarySearch().BSearch(Array, 11));
    }
}