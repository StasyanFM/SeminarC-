// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreatArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите элемент массива под индексом {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
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

// void FindA(int[] array)
// {
//     int A = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) 
//         A += 1;
//     }
    
//     Console.WriteLine($"В полученном массиве, {A} элементов больше 0");
// }

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatArray(size);
// ShowArray(myArray);
// FindA(myArray);
// __________________________________________________________________________________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Intersection(double b1, double k1, double b2, double k2)
{
    // var x = -(b1 - b2) / (k1 - k2);
    // var y = k1 * x + b1;
    
    if(k1 == k2)
    {
        Console.WriteLine($"Линии параллельны друг другу");
    }
    else
    {
        double x = Math.Round(-(b1 - b2) / (k1 - k2), 2);
        double y = Math.Round(k1 * x + b1, 2);
        Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}


Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Intersection(b1, k1, b2, k2);
// ___________________________________________________________________________________________________________________