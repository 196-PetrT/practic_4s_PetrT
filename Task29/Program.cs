// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System.ComponentModel.DataAnnotations;

var array = GenerateArray(8);
/*
int [] array = {}
array[0] = 1;
array[1] = 2;
array[2] = 5;
array[3] = 7;
array[4] = 19;
array[5] = default;
array[6] = default;
array[7] = default;
*/
PrintArray(array);

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 99);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}