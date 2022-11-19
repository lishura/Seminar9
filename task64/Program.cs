// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetPositiveInt (string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(),out value) ^ value <= 0)
    {
        Console.Write("Ошибка " + message);
    }
    return value;
}

string NumbersFromNToOne (int num)
{
    string temp = string.Empty;
    int a = 1;
    if (num>=a)
    {
        return $"{num}, {NumbersFromNToOne(num-1)}";
        num--;
    }
    return temp;
}

int n = GetPositiveInt("Введите число: ");
Console.WriteLine(NumbersFromNToOne(n));