﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];    // выделение памяти под массив
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CountNumber(int[] array)               
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            temp +=1;
        }
    }
    Console.WriteLine($"Четных чисел {temp}");
}

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size, minValue, maxValue);
ShowArray(myArray);
CountNumber(myArray);

