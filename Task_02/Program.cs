//﻿Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите значение m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {AckermannFunction(m, n)}");

static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m == 1)
    {
        return n + 2;
    }
    else if (m == 2)
    {
        return 2 * n + 3;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

