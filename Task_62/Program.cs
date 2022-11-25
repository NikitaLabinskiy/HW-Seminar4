// Задача 62. Напишите метод, который заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int [,] array = new int[4, 4];

int [,] result = FillArrayWithSpiralMethod(array);

PrintArray(result);

Console.WriteLine();

int [,] FillArrayWithSpiralMethod(int [,] array)
{
    int circle = 0;
    int number = 1;
        for (int j = 0; j < 7; j++)
        {
            if(circle == 0)
            {
                for (int e = 0; e < array.GetLength(1); e++)
                {
                    array[j, e] = number++;
                }
            }
            
            if(circle == 1)
            {
                for (int e = 1; e < array.GetLength(1); e++)
                {
                    array[e, array.GetLength(1) - 1] = number++;
                }
            }
            if (circle == 2)
            {
                for (int e = 2; e >= 0; e--)
                {
                    array[array.GetLength(0) - 1 , e] = number++;
                }
            }
            if(circle == 3)
            {
                for (int e = array.GetLength(0) - 2; e >= 1; e--)
                {
                    array[e , 0] = number++;
                }
            }
            if (circle == 4)
            {
                for (int e = array.GetLength(1) - 3; e <= 2; e++)
                {
                    array[1, e] = number++;
                }
            }
            if (circle == 5)
            {
                array[2, 2] = number++;
            }
            if (circle == 6)
            {
                array[2,1] = number++;
            }
            circle++;
        }
    
    return array;
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