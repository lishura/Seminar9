// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkkermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));
    return AkkermanFunction(numberM, numberN);
}

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

int m = GetPositiveInt("Введите число: ");
int n = GetPositiveInt("Введите число: ");

Console.WriteLine(AkkermanFunction(m, n));