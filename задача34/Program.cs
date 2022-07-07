int[] array = new int[10];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        sum++;
    }
}
Console.WriteLine("Задан массив " + "[" + string.Join(", ", array) + "]");
Console.WriteLine($"количество четных чисел в массиве равно {sum}");