/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();
Console.Write("Введите первое число: ");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int input2 = Convert.ToInt32(Console.ReadLine());

int resault = NaturalDegreeOfNumber(input1, input2);
Console.Write(resault);

int NaturalDegreeOfNumber(int number1, int number2)
{
    int size = 0;
    int number = number1;
    while(number2 > 1)
    {
        number2--;
        size++;
    }
    for(int i = 0; i < size; i++)
    {
        number1 *= number;
    }
    return number1;
} 