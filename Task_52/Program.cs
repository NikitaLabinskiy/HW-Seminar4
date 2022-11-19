// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце. 
// Поиск среднее арифметического в отдельном методе. 
// Для создания массива и вывода можно воспользоваться методами из 47 задачи.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

Console.WriteLine();

double [,] array = new double[m, n];

FillArray(array);

PrintArray(array);

Console.WriteLine();
Console.WriteLine("Результат: ");

double [] result = AverageOfAllElementsInEachColumn(array);

PrintFinalArray(result);

void FillArray(double [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11); 
        }
    }
}

void PrintArray(double [,] array)
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

double[] AverageOfAllElementsInEachColumn(double[,] array)
{
    double [] array2 = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count += array[i, j];
        }
        array2[j] = count / array.GetLength(0);
        count = 0;
    }
    return array2;
}

void PrintFinalArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"({array[i]}) ");
    }
}