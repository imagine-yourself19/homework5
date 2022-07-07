decimal[] array = new decimal[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.WriteLine("Выбран массив" + "[" + string.Join(", ", array) + "]");
decimal max = array[0];
decimal min = array[0];
for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
            
Console.WriteLine($"Разность между максимальным {max} и минимальным {min} равна {max - min}");