// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2;   1, -7, 567, 89, 223-> 3


Console.Clear();

Console.Write("Введите колличество элементов: ");

bool size = int.TryParse(Console.ReadLine(), out int s);

int[] numbers = new int[s];

FillArray(numbers);

PrintArray(numbers);

int numberOfPositiveDigits = CheckPositiveNumbers(numbers);

Console.WriteLine();

Console.Write(numberOfPositiveDigits);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CheckPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    return result;
}


