namespace Lecture_Coding;

public class HeapSort
{
    public int[] Sort(int[] array, int size)
    {
        if (size <= 1) return array;

        BuildHeap(array, size);
        

        for (int j = size - 1; j >= 0; j--)
        {
            (array[0], array[j]) = (array[j], array[0]);
            Heapify(array, j, 0);
        }

        return array;
    }

    public void Heapify(int[] array, int size, int index)
    {
        int largestIndex = index;

        if (Left(index) < size && array[Left(index)] > array[largestIndex])
            largestIndex = Left(index);

        if (Right(index) < size && array[Right(index)] > array[largestIndex])
            largestIndex = Right(index);

        if (largestIndex != index)
        {
            (array[index], array[largestIndex]) = (array[largestIndex], array[index]);
            Heapify(array, size, largestIndex);
        }
    }

    public void BuildHeap(int[] array, int size)
    {
        for (int i = size / 2 - 1; i >= 0; i--)
            Heapify(array, size, i);
    }

    public int Left(int i) => i << 1;
    public int Right(int i) => (i << 1) | 1;
    public int Parent(int i) => (i >> 1);

    public void Rootify(int[] array, int index)
    {
        // Controleer of de child daarwerkelijk kleiner is.
        if (index == 1 || array[index] > array[Parent(index)])
            return;

        // Wissel de waarden om, en pas Rootify recursief toe.
        (array[index], array[Parent(index)]) = (array[Parent(index)], array[index]);
        Rootify(array, Parent(index));
    }

    public int ExtractMin(int[] array, int size)
    {
        int result = array[1];

        // Zet de laatste key op de plaats van de root.
        array[1] = array[size--];

        // Corrigeer de heap d.m.v. Heapify.
        Heapify(array, size, 1);

        return result;
    }

    public void Insert(int[] array, int size, int key)
    {
        // Voeg de key toe op de lege eindpositie.
        array[size] = key;

        // Corrigeer de heap d.m.v. Rootify.
        Rootify(array, size);
    }

    /// <summary>
    /// Method to deprioritize a key in Dijkstra's algorithm.
    /// </summary>
    public void DecreaseKey(int[] array, int index, int key)
    {
        // A[i] > k moet gelden.
        if (array[index] < key)
            return;

        array[index] = key;
        // De heap moet worden gecorrigeerd.
        Rootify(array, index);
    }
}
