//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];                                 |
//     for (int i = 0; i < rows; i++)                                           | рандомное заполнение двумерного массива
//     {                                                                        |
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

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


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(array);
// ______________________________________________________________________________________________________________________________

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int [,] Create2DRandomArray(int colums, int rows)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = i + j;

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

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(colums, rows));
// ______________________________________


//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:
//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4


// int [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

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

// int[,] FindNum(int[,] array)
// {
//       for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//              if (i % 2 == 0 && j % 2 ==0)
//              {
//                 array[i,j] *= array[i, j];
//                 // array[i] *= array[i];
//                 // array[j] *= array[j];
//              }

//         }
//     }
//     return array;
// }


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(MyArray);
// Console.WriteLine();
// FindNum(MyArray);
// Console.WriteLine();
// Show2DArray(MyArray);
// _________________________________________________________________________________________________________________________________________

//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2                Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

int [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue+1);
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

int FindMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum = array[i, j] + sum;
        }

    }
    return sum;

}

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = Create2DRandomArray(colums, rows, minValue, maxValue);
Show2DArray(MyArray);
Console.WriteLine();
// FindMainDiagonal(MyArray); так нельзя
Console.WriteLine(FindMainDiagonal(MyArray));