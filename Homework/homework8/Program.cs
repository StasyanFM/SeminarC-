﻿
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);

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

// void SortMaxToMin(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
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

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// SortMaxToMin(myArray);
// Show2DArray(myArray);
// _____________________________________________________________________________________________________________________________________________


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);

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

// void MinSumRow(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         minRow += array[0, j];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRow += array [i, j];   
//         }
//         if(sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }
// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// MinSumRow(myArray);
// ______________________________________________________________________________________________________________________________________


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FirstArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArrayFirst = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArrayFirst[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return newArrayFirst;
}

int[,] SecondArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArraySecond = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArraySecond[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return newArraySecond;
}

void ShowArray(int[,] array)
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

int[,] ResultArray(int[,] FirstArray, int[,] SecondArray)
{   
    int rows = 0;
    int colums = 0;
    int[,] ResArray = new int [rows, colums];
    for (int i = 0; i < FirstArray.GetLength(0); i++)
    {
        for (int j = 0; j < SecondArray.GetLength(1); j++)
        {
            ResArray[i, j] = 0;
            for (int k = 0; k < FirstArray.GetLength(1); k++)
            {
                ResArray[i, j] += FirstArray[i, k] * SecondArray[k, j];
            }
        }
    }
    return ResArray;
}

Console.WriteLine("Введите количество строк массивов:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массивов:");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массивов: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массивов: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = FirstArray(colums, rows, minValue, maxValue);
int[,] myArray2 = SecondArray(colums, rows, minValue, maxValue);
int[,] myArray3 = ResultArray(FirstArray, SecondArray); // ???
ShowArray(myArray1);
ShowArray(myArray2);
ShowArray(myArray3);



// _________________________________________________________________________________________________________________________________________




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// bool FindElementIn3DArray(int[,,] array, int elementRow, int elementCol, int elementVert)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (i < elementRow)
//     {
//     }
//     for (int j = 0; j < array.GetLength(2); j++)
//     {
//       if (i != elementRow && j != elementCol)
//       {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//           if (array[i, j, k] == array[elementRow, elementCol, elementVert])
//           {
//             return true;
//           }
//         }
//       }
//       else
//       {
//         for (int k = 0; k < elementVert; k++)
//         {
//           if (array[i, j, k] == array[elementRow, elementCol, elementVert])
//           {
//             return true;
//           }
//         }
//       }
//     }
//   }
//   return false;
// }

// int[,,] Create3DRandomArray(int rows, int columns, int verticals, int minValue = 10, int maxValue = 99)
// {
//   int[,,] newArray = new int[rows, columns, verticals];

//   for (int i = 0; i < newArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//       for (int k = 0; k < newArray.GetLength(2); k++)
//       {
//         newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//         while (FindElementIn3DArray(newArray, i, j, k))
//         {
//           newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//         }
//       }
//     }
//   }
//   return newArray;
// }

// void Print3DArray(int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Console.Write($"{array[i, j, k]} ({i},{j},{k}){(k != array.GetLength(2) - 1 ? "   " : "")}");
//       }
//       Console.WriteLine();
//     }
//   }
// }

// Console.WriteLine("Введите количество строк массива:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of rows in array: ");
// Console.Write("Введите количество вертикалей массива: ");
// int verticals = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(rows, colums, verticals);
// Print3DArray(myArray);



// ____________________________________________________________________________________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

