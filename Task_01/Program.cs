//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите значение M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());

if (m <= n)
{
    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    PrintNaturalNumbers(m, n);
}
else
{
    Console.WriteLine("Значение M должно быть меньше или равно N.");
}


static void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        PrintNaturalNumbers(m + 1, n);
    }
}
