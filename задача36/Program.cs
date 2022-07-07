int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
}
Console.WriteLine("Выбран  массив" + "[" + string.Join(", ", array) + "]");
int nechetSum = 0;
for (int i = 1; i < array.Length; i += 2)
    {
        nechetSum = nechetSum + array[i];
    }
Console.WriteLine($"Сумма чисел на нечетных позициях равна {nechetSum}");