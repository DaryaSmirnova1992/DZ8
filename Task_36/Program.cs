// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array= new int [10];
int size= array.Length;
int oddSum = 0;

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-1000,1000);

    if(i % 2 > 0)
    {
        oddSum += array[i];
    }
}
Console.WriteLine("[{0}]", String.Join(",",array));
Console.WriteLine("Сумма элементов на нечётных позициях = "+ oddSum);