//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2
//РЕАЛИЗУЕМ МЕТОД ПОИНТЕРЕСНЕЕ ОН БУДЕТ МЕНЯТЬ ЛЮБУЮ С ЛЮБОЙ СТРОКИ


int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

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

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {
//     row1 --; // уменьшаем на 1 чтобы пользоватьель 
//     row2 --;
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
//         {
//             Console.WriteLine("Введены неверные строки");
//             return array;
//         }
//     else
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите строку которую хотите заменить: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите строку на которую хотите заменить: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// myArray = ChangeRows(myArray, row1, row2);
// Show2DArray(myArray);
// __________________________________________________________________________________________________________________________________

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7


// int[,] RowsToColums(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Введены неверные строки");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++) // -1 для того чтобы в последней строке не проверять так как там точно ничего нет 
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите строку которую хотите заменить: ");

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(array);
// Show2DArray(RowsToColums(array));
// ______________________________________________________________________________________________________________________________________

//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент



// минимум
int[,] DeleteMinElement(int[,] array)
{
    int min = array[0, 0];
    int rowMin = 0;
    int columMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                rowMin = i;
                columMin = j;
            }
        }
    }
    // обнуление столбцов
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, columMin] = 0;
    }
    // обнуление строки
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[rowMin, j] = 0;
    }
    return array;
}

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
Show2DArray(array);
Show2DArray(DeleteMinElement(array));