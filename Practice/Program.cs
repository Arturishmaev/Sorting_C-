// Сортировка выбором.
/*System.Console.WriteLine("Введите количестов элементов массива:");
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
System.Console.WriteLine("Отсортированый массив: [" + string.Join(", ", array)+ "]");*/

// Сортировка пузырьком

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