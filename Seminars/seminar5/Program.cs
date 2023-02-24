//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindPosNegSum(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0) 
//         sumPositive += array[i];
//         else
//         sumNegative += array[i];
//     }
//     Console.WriteLine($"Sum of positiv numbers is array -> {sumPositive}, sum of negative is array {sumNegative} ");
// }
// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// FindPosNegSum(myArray);
// ______________________________________________________________________________________________________________________________________

////Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] InvertArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = InvertArray(myArray); // перезеапись массива который мы изначально получили 
// ShowArray(myArray); // показываем перезаписанный инвертированный массив
// _______________________________________________________________________________________________________________________________________

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4 массив [6, 7, 19, 345, 3] -> нет

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool FindElement(int[] array, int num)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if(array[i] == num)
//         {
//             return true;
//         }
//     }
//         return false;
// }

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = CreatRandomArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine($"Число {num} масиива: {FindElement(array, num)}");
// ________________________________________________________________________________________________________________________________________

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

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

int CountElementsInDiapason(int[] array)
{
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] <= 99)
    {
      count++;
    }
  }
  return count;
}

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreatRandomArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine($"{CountElementsInDiapason(array)} елемент находится в диапазоне [10, 99]");