//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuar(double x, double y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;

//     return 0;
// }

// Console.WriteLine("Введите X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y:");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindQuar(x, y));
// ___________________________________________________________________________________________________________________________________________-

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

double FindDistance(double xA, double yA, double xB, double yB)
{
    return Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)), 2);
}

Console.WriteLine("Введите координату xA:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату yA:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату xB:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату yB:");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками -> {FindDistance(xA, yA, xB, yB)}");
// ______________________________________________________________________________________________________________________________________________