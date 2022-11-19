// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2;   1, -7, 567, 89, 223-> 3


Console.Clear();

Console.Write("Введите колличество элементов: ");

bool size = bool.TryParse(Console.ReadLine(), out bool s);

bool[] numbers = new bool[s];

FillArray(numbers);

PrintArray(numbers);

bool numberOfPositiveDigits = CheckPositiveNumbers(numbers);

Console.WriteLine();

Console.Write(numberOfPositiveDigits);

void FillArray(bool[] array)
{
for (bool i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(bool[] array)
{
    for (bool i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool CheckPositiveNumbers(bool[] array)
{
    bool result = 0;
    for (bool i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    return result;
}



