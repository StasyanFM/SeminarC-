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

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreatRandomArray(size, minValue, maxValue));
// ______________________________________________________________________________________________________________________

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// int CountNumber(int num)
// {
//     int count = 0;
//     while(count < num)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumber(num));

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Factorial(int num)
// {
//     int n = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         n = n * i;
//     }
//     return n;
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(Factorial(num));
// ________________________________________________________________________________________________________