// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

                        // int secondNumber(int num)
                        // {
                        //     int Number = num / 10 % 10;
                        //     return Number;
                        // }
                        // Console.WriteLine("Введите число трехзначное число");
                        // int num = Convert.ToInt32(Console.ReadLine());
                        // Console.WriteLine(secondNumber(num));

int secondNumber(int num)
{
    int Number = num / 10 % 10;
    if (num < 999)
    {
        return Number;
    }
    else
    {
        Console.WriteLine($"Введенное число {num} не трехзначное, введите корректное число");
        return 0;
    }
}
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(secondNumber(num));
