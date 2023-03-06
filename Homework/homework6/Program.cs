// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreatArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindA(int[] array)
{
    int A = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) 
        A += 1;
    }
    
    Console.WriteLine($"В полученном массиве, {A} элементов больше 0");
}

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatArray(size);
ShowArray(myArray);
FindA(myArray);
// __________________________________________________________________________________________________________________