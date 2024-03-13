﻿// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

    {
        int[] array = { 1, 2, 3, 4, 5 };
        ArrayReverse(array, array.Length - 1);
    }
    static void ArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
          return;
        }
        Console.WriteLine(array[index]);
        ArrayReverse(array, index - 1);
    }
