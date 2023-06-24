namespace Lecture_Coding.Midterm;

public class Sorting
{
    /// <summary>
    /// Optimized function for the sorting algorithm "insertion sort".
    /// </summary>
    public int[] InsertionSort(int[] A)
    {
        int l = A.Length;

        for (int i = 1; i < l; i++)
        {
            int temp = A[i];
            int j = i - 1;

            while (j >= 0 && A[j] > temp)
            {
                A[j + 1] = A[j];
                j--;
            }
            A[j + 1] = temp;
        }

        return A;
    }

    /// <summary>
    /// Optimized function for the sorting algorithm "selection sort".
    /// </summary>
    public int[] SelectionSort(int[] A)
    {
        int l = A.Length;

        // Main loop that will execute the sorting logic for all elements in the array.
        for (int i = 0; i < l - 1; i++)
        {
            int minIndex = i;

            // Loops through the array, looking for the eventual smallest value.
            for (int j = i + 1; j < l; j++)
                if (A[j] < A[minIndex]) minIndex = j;

            // Swaps the values.
            if (minIndex != i)
                (A[i], A[minIndex]) = (A[minIndex], A[i]);
        }

        return A;
    }

    public int[] QuickSort(int[] A, int l, int r)
    {
        if (l < r)
        {
            int res = Split(A, l, r);
            QuickSort(A, l, res - 1);
            QuickSort(A, res + 1, r);
        }

        return A;
    }

    public int Split(int[] A, int l, int r)
    {
        int pivot = A[l];
        int start = l, end = r;

        while (start < end)
        {
            while (A[start] <= pivot) start++;
            while (A[end] > pivot) end--;
            if (start < end)
                (A[start], A[end]) = (A[end], A[start]);
        }

        (A[l], A[end]) = (A[end], A[l]);

        return end;
    }
}
