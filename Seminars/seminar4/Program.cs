// //Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

int FindSum(int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
    {
        sum = sum + current; // sum+=current - альтернативная запись
    }
    return sum;
}
Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSum(a));
// __________________________________________________________________________________________________________