// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите элемент b1: ");
bool B1 = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("Введите элемент k1: ");
bool K1 = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("Введите элемент b2: ");
bool B2 = double.TryParse(Console.ReadLine(), out double b2);
Console.Write("Введите элемент k2: ");
bool K2 = double.TryParse(Console.ReadLine(), out double k2);

(double,double) result = PodoubleOfdoubleersectionOfTwoLines(b1, k1, b2, k2);

Console.WriteLine(result);

(double,double) PodoubleOfdoubleersectionOfTwoLines (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
    return (x, y);
}
