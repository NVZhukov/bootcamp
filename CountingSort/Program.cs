// сортировка подсчетом

int[] array = { 33, 1, 5, 9, -10, 1, 0, 4, 25 };
int[] sortedArray = CountingSortExtended(array);
System.Console.WriteLine(string.Join(", ", sortedArray));

void CountingSort(int[] inputArray)
{
    int[] countArray = new int[10];
    for (int i = 0; i < inputArray.Length; i++)
    {
        countArray[inputArray[i]]++;
    }

    int index = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        for (int j = 0; j < countArray[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

int[] CountingSortExtended(int[] inputArray)
{
    int maxNum = inputArray.Max();
    int minNum = inputArray.Min();
    int offset = -minNum;

    int[] countArray = new int[maxNum + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        countArray[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        for (int j = 0; j < countArray[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
    return inputArray;
}