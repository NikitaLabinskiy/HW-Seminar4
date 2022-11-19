// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
// m и n вводит пользователь в консоль
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество строк: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

double [,] array = new double[m, n];

FillArray(array);

PrintArray(array);

void FillArray(double [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // array[i, j] = random.Next(-10, 11) + random.NextDouble(); // первый вариант решения
            double number = random.Next(-100, 101); // второй вариант решения
            array[i, j] = number / 10;
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