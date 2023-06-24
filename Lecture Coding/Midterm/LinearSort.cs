namespace Lecture_Coding.Midterm;

public class LinearSort
{
    /// <summary>
    /// Finds the highest value present in a given array.
    /// </summary>
    public int FindMaxValue(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];

        return max;
    }

    /// <summary>
    /// Optimized function for the sorting algorithm "counting sort".
    /// </summary>
    public int[] CountingSort(int[] array)
    {
        int n = array.Length;

        int max = FindMaxValue(array);

        int[] count = new int[max + 1];

        for (int i = 0; i < max + 1; i++)
            count[i] = 0;

        for (int i = 0; i < n; i++)
            count[array[i]]++;

        for (int i = 0, j = 0; i <= max; i++)
        {
            while (count[i] > 0)
            {
                array[j] = i;
                j++;
                count[i]--;
            }
        }

        return array;
    }

    /// <summary>
    /// Optimized function for the sorting algorithm "radix sort".
    /// </summary>
    public int[] RadixSort(int[] array)
    {
        int max = FindMaxValue(array);

        // The 10 is used to simulate exponents, where i is the current digit.
        for (int i = 1; max / i > 0; i *= 10)
            RadixCountingSort(array, i);

        return array;
    }

    /// <summary>
    /// Adjusted function for counting sort to be paired with radix sort.
    /// </summary>
    public int[] RadixCountingSort(int[] array, int exponent)
    {
        int n = array.Length;
        int[] temp = new int[n];
        int[] count = new int[10];

        for (int i = 0; i < 10; i++)
            count[i] = 0;

        for (int i = 0; i < n; i++)
            // Modulo 10 because of the exponents.
            count[array[i] / exponent % 10]++;

        // count[i] should store the actual position of the digit.
        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        // Once the array positions are stored, the elements should be set
        // based on the sorted position as they're added to the temp array.
        for (int i = n - 1; i >= 0; i--)
        {
            temp[count[array[i] / exponent % 10] - 1] = array[i];
            count[array[i] / exponent % 10]--;
        }

        for (int i = 0; i < n; i++)
            array[i] = temp[i];

        return array;
    }

    public int[] BucketSort(int[] array)
    {
        int max = array[0], min = array[0];
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }

        LinkedList<int>[] bucket = new LinkedList<int>[max - min + 1];

        // The ultimate goal is to store each array element in its corresponding index,
        // and move everything to the left (min) if possible during the process.
        for (int i = 0; i < n; i++)
        {
            bucket[array[i] - min] ??= new LinkedList<int>(); // check for null
            bucket[array[i] - min].AddLast(array[i]);
        }

        int index = 0;

        // Moves the elements from the bucket (linked list) back into the array.
        foreach (var t in bucket)
        {
            if (t != null)
            {
                LinkedListNode<int>? node = t.First;

                while (node != null)
                {
                    array[index] = node.Value;
                    node = node.Next;
                    index++;
                }
            }
        }

        return array;
    }
}