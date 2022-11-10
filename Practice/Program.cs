// Сортировка выбором.

System.Console.WriteLine("Введите количестов элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    System.Console.Write("Введите число :");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine();
System.Console.WriteLine("Начальный массив: [" + string.Join(", ", array)+ "]");
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[minIndex])
        {
            minIndex = j;
        }
    }
     int temp = 0;
     temp = array[minIndex];
     array[minIndex] = array[i];
     array[i] = temp;
}
System.Console.WriteLine("Отсортированый массив: [" + string.Join(", ", array)+ "]");

// Сортировка пузырьком.

System.Console.WriteLine("Введите количестов элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    System.Console.Write("Введите значение элемента массива :");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine();
System.Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
 System.Console.WriteLine("Отсортированый массив: [" + string.Join(", ", array)+ "]");

// Быстрая сортировка.

System.Console.WriteLine("Введите количестов элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    System.Console.Write("Введите число :");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine();
System.Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

void QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return;
    }
    int pivot = GetPivotIndex(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivot - 1);
    QuickSort(array, pivot + 1, maxIndex);
    return;
}

int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivotIndex++;
            Swap(array, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(array, pivotIndex, maxIndex);
    return pivotIndex;
}

void Swap(int[] array, int leftValue, int rightValue)
{
    int temp = array[leftValue];
    array[leftValue] = array[rightValue];
    array[rightValue] = temp;

}
QuickSort(array, 0, array.Length - 1);
System.Console.WriteLine("Отсортированый массив: [" + string.Join(", ", array) + "]");