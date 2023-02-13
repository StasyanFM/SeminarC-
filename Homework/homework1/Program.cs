// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"Number {num1} more than number {num2}");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine($"Number {num2} more than number {num1}");
// }
// else
// {
//     Console.WriteLine($"Number {num1} equals number {num2}");
// }
// _____________________________________________________________________________________________________________________

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) 
// {
//     max = num2;
// }
// if (num3 > max) 
// {
//     max = num3;
// }
// Console.WriteLine($"Число {max} наибольшее из введенных чисел");
// ________________________________________________________________________________________________________________________

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine($"Число {num} является четным числом");
// }
// else
// {
//   Console.WriteLine($"Число {num} является нечетным числом");  
// }
// __________________________________________________________________________________________________________________________

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int current = num / (num / 2);
while (current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}

// do
// {
//     Console.Write(current + " ");
//     current = current + 2;
// }
// while (current <= num);