// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите метод, который будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int [,] array = new int [m, n];

FillArray(array);

PrintArray(array);

Console.WriteLine();

int[] arrayOfSum = FindSumOfNumbersInRow(array);

PrintSecondArray(arrayOfSum);

Console.WriteLine();

// int result = FindRowWithMinimumSumOfElements(arrayOfSum);

FindRowWithMinimumSumOfElements(arrayOfSum);

// Console.WriteLine(result);


void FillArray (int [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintSecondArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] FindSumOfNumbersInRow (int [,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
        sum = 0;
    }
    return result;
}

void FindRowWithMinimumSumOfElements(int [] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Минимальная сумма: {min}");
    Console.Write($"Строка с наименьшей суммой элементов: {index + 1}");
}