// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 , 7 -> такого числа в массиве нет
// 1 , 1 -> 1

Console.Clear();

Console.Write("Введите индекс строки: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите индекс столбца: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int [,] array = new int[5, 5];

FillArray(array);

PrintArray(array);

Console.WriteLine();

FindArrayElementByIndex(array, m, n);

void FillArray(int [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10, 21); 
        }
    }
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindArrayElementByIndex(int [,] array, int m, int n)
{
    if (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.Write("Такого числа в массиве нет!");
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             if ( i == m && j == n){Console.WriteLine($"Значение элемнта: {array[i, j]} ");}
        }
    }
}