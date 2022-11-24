// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите размер по оси Z: ");
bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);

Console.Write("Введите размер по оси y: ");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

Console.Write("Введите размер по оси x: ");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

int [,,] array3D = new int [z, y, x];

FillArray(array3D);

PrintArray(array3D);

void FillArray(int [,,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < array.GetLength(2); e++)
            {
                int number = random.Next(10, 100);
                if (CheckNumberExist(array, number) == true)
                {
                    array[i, j, e] = number;
                }
                else
                {
                    e--;
                }
            }
        }
    }
}

bool CheckNumberExist(int [,,] array, int random)
{
    bool result = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < array.GetLength(2); e++)
            {
                if(array[i, j, e] == random)
                result = false;
            }
        }
    }
    return result;
}


void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < array.GetLength(2); e++)
            {
                Console.Write($"{array[i, j, e]} {(i, j, e)} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}