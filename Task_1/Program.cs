// Написать программу которая находит сумму 4 чисел. Числа вводятся пользователем из консоли.
// Если пользователь ввел не число необходимо вывести пользователю сообщение "Введены некорректные данные".

Console.Clear();

Console.Write("Введите количество слагаемых чисел: ");
bool Y = int.TryParse(Console.ReadLine(), out int x);

if(!Y)
{
    Console.Write("Ошибка! Не правильно введены данные.");
    return;
}

int res = AdditionOfNumbers(x);

Console.Write(res);

int AdditionOfNumbers(int number)
{
    int resault = 0;
    for(int i = 0; i < number; i++)
    {
        Console.Write("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        resault = x + resault;
    }
    return resault;
}
