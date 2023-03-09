﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     double [,] newArray = new double[rows, colums];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = Math.Round(rand.Next(minValue, maxValue)*0.1, 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double [,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(array);
// ____________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue + 1, maxValue + 1);

//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeElement(int[,] array, int row, int colum)
// {
//     {
//         row--;
//         colum--;
//         if (colum > array.GetLength(0) && row > array.GetLength(1)) // почему если напишу if (row > array.GetLength(0) && colum > array.GetLength(1)) и при выполнении данного условия не срабатывает предупреждение 
//         {
//             Console.WriteLine($"Элемента в строке {row + 1} и столбце {colum + 1} -> не существует");
//         }
//         else
//         {
//             object temp = array.GetValue(row, colum); // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL. 
//             Console.WriteLine($"Элемент в строке {row + 1} и столбце {colum + 1} -> {temp}");
//         }
//     }
// }

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите строку необходимого элемента: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец необходимого элемента: ");
// int colum = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = Create2DRandomArray(rows, colums, minValue, maxValue);
// Show2DArray(myArray);
// ChangeElement(myArray, row, colum);
// _________________________________________________________________________________________________________________________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue);

        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeAverage(int[,] array)
{        
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average = average + array[i, j];
        }
            Console.Write($"{average / array.GetLength(0)}; ");
    }
}

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, colums, minValue, maxValue);
Show2DArray(myArray);
ChangeAverage(myArray);