/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Задание должно быть выполнено в методах.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]*/

Console.Clear();

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите один элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Вывод массива: ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

FillArray(array);