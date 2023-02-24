// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num)
{
    int fives = num % 10;
    int fourth = ((num % 100) - fives) / 10;
    int second = (num / 1000) % 10;
    int first = num / 10000;
    if (fives == first && fourth == second)
    {
        Console.WriteLine($"Число {num} -> полиндромно");
    }
    else
    {
        Console.WriteLine($"Число {num} -> не полиндромно");
    }

}
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);

// _________________________________________________________________________________________________________________________

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)), 2);
// }

// Console.WriteLine("Введите координату xA:");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату yA:");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату zA:");
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату xB:");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату yB:");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату zB:");
// double zB = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine($"Расстояние между точками -> {FindDistance(xA, yA, zA, xB, yB, zB)}");
// _________________________________________________________________________________________________________________________

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void FindQuard(int n)
// {
//     int i = 1;
//     int step = 3;
//         while (i <= n)
//     {
//         Console.WriteLine($"Куб числа {i} -> " + Math.Pow(i, step));
//         i++;
//     }
// }

// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// FindQuard(n);
