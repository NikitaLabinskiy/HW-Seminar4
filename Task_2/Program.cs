// Написать программу которая считывает из консоли 2 числа A и B и определяет делится ли число А на B без остатка.
//  Результатом выполнения программы должно быть вывода сообщения пользователю true или false.
// true - если делится. false - если не делится.
Console.Clear();

Console.Write("Введите первое число: ");
bool number1 = int.TryParse(Console.ReadLine(), out int x);
Console.Write("Введите второе число: ");
bool number2 = int.TryParse(Console.ReadLine(), out int y);

bool resault = DevisionOfNumbers(x, y);

Console.Write(resault);

if(!number1 || !number2)
{
    Console.Write("Ошибка! Не правильно введены данные.");
    return;
}

bool DevisionOfNumbers(int x, int y)
{
    if (x % y == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}