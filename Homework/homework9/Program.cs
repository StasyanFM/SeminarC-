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

int SumNum(int m, int n)
{
    int res = m;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        res = m + SumNum(m, n);
        return res;
    }
}

void SumMtoN(int m, int n)
{
    Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} -> {SumNum(m-1, n)}");
}

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumMtoN(m, n);
// __________________________________________________________________________________________________________________