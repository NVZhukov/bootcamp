/*
Быстрая сортировка:
Время выполнения : O (n * log n)
Память : O (n)
*/

System.Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] inputArray = FillArray(n);
int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }
    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);
    return pivot;
}

void Swap(ref int leftItem, ref int rightItem)
{
    int temp = leftItem;
    leftItem = rightItem;
    rightItem = temp;
}

int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 100);
    }
    return mas;
}