// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[4];
            int A = 0;
        
            Console.WriteLine("Массив");
            for (int i = 0; i < 4; i++)
            {
                array[i] = new Random().Next(100, 1000);
                
            }
                Console.WriteLine("[{0}]", string.Join(",",array));
            

            foreach(int element in array)
            {
                
                if (element % 2 == 0)
                {
                    A++;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов: {0}", A);
