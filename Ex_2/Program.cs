// ex 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int Summa(int n)
{
    int result = 0;
    while (n > 0)
    {
        result = result + n % 10;
        n = n / 10;
    }
    return result;
}
Console.WriteLine($"Сумма цифр в числе {n} равна {Summa(n)}");