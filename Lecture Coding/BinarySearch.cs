namespace Lecture_Coding;

public class BinarySearch
{
    /// <summary>
    /// Function discussed during the first lecture.
    /// </summary>
    public int Search(int[] A, int n)
    {
        int i = -1;
        int j = A.Length;

        while (i < j - 1)
        {
            int m = (i + j) / 2;

            if (A[m] < n) i = m;
            else j = m;
        }

        return j;
    }

    /// <summary>
    /// Function written myself that resolves issues with the "Search" function.
    /// </summary>
    public string BSearch(int[] array, int num)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int avg = (left + right) / 2;

            if (array[avg] == num) return $"The index of the value is {avg}.";
            if (num < array[avg]) right = avg - 1;
            else left = avg + 1;
        }
        return "That element does not occur within the given array.";
    }

}