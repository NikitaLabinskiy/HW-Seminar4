// Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.Write("Введите количество строк 1 матрицы: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов 1 матрицы: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Введите количество строк 2 матрицы: ");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

Console.Write("Введите количество столбцов 2 матрицы: ");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

int [,] matrix1 = new int[m, n];
int [,] matrix2 = new int[x, y];

FillArray(matrix1);

PrintArray(matrix1);

Console.WriteLine();

FillArray(matrix2);

PrintArray(matrix2);

Console.WriteLine();

int [,] result = ProductOfTwoMatrices(matrix1, matrix2);

Console.WriteLine("Произведение матриц: ");

PrintArray(result);

void FillArray(int [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 6); 
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

int [,] ProductOfTwoMatrices(int [,] array1, int [,] array2)
{
    // if (array1.GetLength(1) != array2.GetLength(0))             
    // {
    //     throw new Exception($"Матрицы нельзя перемножить");
    // }
    int [,] arrayProduct = new int [array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int e = 0; e < array1.GetLength(0); e++)
            {
                arrayProduct[i, j] += array1[i, e] * array2[e, j];
            }
        }
    }
    return arrayProduct;
}