// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    int[] array = new int[10];
    int max=0, min=100;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
Console.WriteLine("[{0}]", String.Join(",",array));
Console.WriteLine("max: " + max);
Console.WriteLine("min: " + min);
Console.WriteLine("Разница максимального и минимального:  "+(max - min));
        