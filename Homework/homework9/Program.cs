// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumber(int n)
// {
//     if (n == 0)
//     {
//         return;
//     }
//     Console.Write(n + " ");
//     ShowNumber(n - 1);
// }

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumber(n);
// __________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNum(int m, int n)
// {
//     if (m < n)
//     {
//         if (m < n)
//         {
//             return SumNum(m + 1, n) + m;
//         }
//     }
//     else if (m > n)
//     {
//         if (m > n)
//         {
//             return SumNum(m, n + 1) + n;
//         }
//     }
//     return n;
// }

// Console.WriteLine("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} -> {SumNum(m, n)}");

// __________________________________________________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FuncAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else
    {
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }
}

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана -> {FuncAkkerman(m, n)}");