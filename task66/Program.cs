// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetPositiveInt(string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <= 0)
    {
        Console.Write("Ошибка " + message);
    }
    return value;
}

string NumbersFromMtoN(int m, int n)
{
    string temp = string.Empty;

    if (n >= m)
    {
        return $"{m}, {NumbersFromMtoN(m + 1, n)}";
        
    }
    return temp;
}

int m = GetPositiveInt("Введите начальное целое число: ");
int n = GetPositiveInt("Введите конечное целое число: ");

if (n<m)
{
    Console.WriteLine("Ошибка, начальное число должно быть меньше конечного ");
}
Console.WriteLine(NumbersFromMtoN(m, n));

