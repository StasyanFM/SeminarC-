// //Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for (int current = 1; current <= a; current++)
//     {
//         sum = sum + current; // sum+=current - альтернативная запись
//     }
//     return sum;
// }
// Console.WriteLine("Введите число А:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum(a));
// __________________________________________________________________________________________________________

// //Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.(задание скооректировано - заполняем разными числами, размер задаем любой)

// [1,0,1,1,0,1,0,0]

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

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива:");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowArray(CreatRandomArray(size, minValue, maxValue));
