// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


                                        // int secondNumber(int num)                                |
                                        // {                                                        |
                                        //     int Number = num / 10 % 10;                          |
                                        //     return Number;                                       |   тест
                                        // }                                                        |
                                        // Console.WriteLine("Введите число трехзначное число");    |
                                        // int num = Convert.ToInt32(Console.ReadLine());           |
                                        // Console.WriteLine(secondNumber(num));                    |

// int secondNumber(int num)
// {
//     int Number = num / 10 % 10;
//     if (num < 999)
//     {
//         return Number;
//     }
//     else
//     {
//         Console.WriteLine($"Введенное число {num} не трехзначное, введите корректное число");
//         return 0;
//     }
// }
// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(secondNumber(num));
// ___________________________________________________________________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int thirdNumber(int num)                                                 |
// {                                                                        |
//     int Number = num / 10 % 10;                                          |
//     if (num > 999)                                                       |
//     {                                                                    |
//        return Number;                                                    |
//     }                                                                    |
//         else                                                             |       не готово
//     {                                                                    |
//         Console.WriteLine("третьей цифры нет");                          |
//         return 0;                                                        |
//     }                                                                    |
// }                                                                        |
// Console.WriteLine("Введите число");                                      |
// int num = Convert.ToInt32(Console.ReadLine());                           |
// Console.WriteLine(thirdNumber(num));                                     |


                                    // int thirdNumber(int num)
                                    // {
                                    //     while (num > 999)
                                    //     {
                                    //        num /= 10;
                                    //     }
                                    //     return num % 10;

                                    //     if (num < 100);
                                    //     {
                                    //         Console.WriteLine("Введите число");
                                    //         return 0;
                                    //     }
                                    // }
                                    // Console.WriteLine("Введите число");
                                    // int num = Convert.ToInt32(Console.ReadLine());
                                    // Console.WriteLine(thirdNumber(num));
// _______________________________________________________________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());

void Day(int[] array)
{
    if (day > array.Length || day == 0)
    {
        Console.Write($"{day} -> Такого дня недели нет!");
    }
    else if (day < array.Length - 1)
    {
        Console.Write($"{day} -> Будний день");
    }
    else
    {
        Console.Write($"{day} -> Выходной день");
    }
}
Day(arr);