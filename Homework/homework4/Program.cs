﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// void FindStep(int n)
// {
//     Console.WriteLine("Введите степень в которую необходимо возвести число:");
//     int step = Convert.ToInt32(Console.ReadLine());
//     double res = Math.Pow(n, step);
//         if (n >= 0)
//     {
//         Console.WriteLine($"Число {n} в степени {step} -> {res}" );  // + Math.Pow(n, step)
//     }
//     else
//     {
//          Console.WriteLine($"Введенное Вами число {n} на натуральное!");
//     }
// }

// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите степень в которую необходимо возвести число:"); если тут стоит ввод step то Ошибка: Невозможно использовать локальную переменную "step" перед ее объявлением. как правильно объявить переменную
// // int step = Convert.ToInt32(Console.ReadLine()); 
// FindStep(n);

// void FindStep(int n)
// {
//     Console.WriteLine("Введите степень в которую необходимо возвести число:");
//     int step = Convert.ToInt32(Console.ReadLine());
//     double res = Math.Pow(n, step);
//         if (step >= 1)
//     {
//         Console.WriteLine($"Число {n} в степени {step} -> {res}" );
//     }
//     else
//     {
//          Console.WriteLine($"Введенная Вами степень {step} на натуральное число!");
//          Console.WriteLine($"Натуральные числа - числа, возникающие естественным образом при счёте (1, 2, 3, 4, 5, 6, 7 и так далее).");
//     }
// }

// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// FindStep(n);
// _______________________________________________________________________________________________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


