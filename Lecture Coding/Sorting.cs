namespace Lecture_Coding;

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
            int minValue = A[i];

            // Loops through the array, looking for the eventual smallest value.
            for (int j = i + 1; j < l; j++)
                if (A[j] < A[minIndex]) minIndex = j;

            // Swaps the values.
            if (minIndex != i)
            {
                int temp = A[i];
                A[i] = minValue;
                A[minIndex] = temp;
            }
        }

        return A;
    }

    public int[] QuickSort(int[] A, int p, int r)
    {
        if (p < r)
        {
            int q = Split(A, p, r);
            QuickSort(A, p, q - 1);
            QuickSort(A, q + 1, r);
        }

        return A;
    }

    public int Split(int[] A, int l, int r)
    {
        int i = l - 1;

        for (int j = l; j < r - 1; j++)
            if (A[j] <= A[r - 1])
            {
                i++;

                (A[j], A[i]) = (A[i], A[j]);
            }
        (A[r - 1], A[i + 1]) = (A[i + 1], A[r - 1]);

        return i + 1;
    }
}
