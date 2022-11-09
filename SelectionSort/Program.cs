/*
Сортировка выбором:
Время выполнения : O (n ^ 2 / 2)
Память : O (n + 1)
*/

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

for (int i = 0; i < n - 1; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[MinIndex] > array[j])
            MinIndex = j;
    }
    int temp = array[i];
    array[i] = array[MinIndex];
    array[MinIndex] = temp;
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
Console.WriteLine("Отсортированный массив: [" + string.Join(", ", array) + "]");