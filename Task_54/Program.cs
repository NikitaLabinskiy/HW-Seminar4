// Задача 54: Задайте двумерный массив. 
// Напишите метод, который упорядочит по убыванию элементы каждой строки двумерного массива. 
// И продемонстрируйте его работу.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int [,] array = new int [m, n];

FillArray(array);

PrintArray(array);

Console.WriteLine();

SortElementsInDescendingOrder(array);

PrintArray(array);

void FillArray (int [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10, 51);
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

void SortElementsInDescendingOrder(int [,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int max = array[k, j];
                if (array[k, i] > max)
                {
                    int temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }
            }
        }
    }
}