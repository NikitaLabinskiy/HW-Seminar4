Console.Clear();

Console.Write("Введите первое слово: ");
string word1 = Console.ReadLine();
Console.Write("Введите второе слово: ");
string word2 = Console.ReadLine();

bool resault = CompareWords(word1, word2);

Console.Write(resault);

bool CompareWords(string x, string y)
{
    if (x == y)
    {
        return true;
    }
    else
    {
        return false;
    }
}