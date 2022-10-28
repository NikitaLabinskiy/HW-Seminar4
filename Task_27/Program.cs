/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
452 -> 11; 82 -> 10; 9012 -> 12*/

Console.Clear();

Console.Write("Введите число: ");

int input = Convert.ToInt32(Console.ReadLine());

int result = SumOfNumber(input);

Console.Write(result);

int SumOfNumber(int number)
{
    int lustdigit = 0;
    int result = 0; 
    for(int i = 0; i < number; i++)
    {
        lustdigit = number % 10;
        number = number / 10;
        result += lustdigit;
    }
    return result;
} 