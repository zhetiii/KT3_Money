using System;

public class Money
{
    public decimal Amount { get; }

    // 1. Конструктор просто сохраняет сумму
    public Money(decimal amount)
    {
        Amount = amount;
    }

    // 2. Бинарный плюс (сложение двух сумм)
    public static Money operator +(Money a, Money b) => new Money(a.Amount + b.Amount);

    // 3. Бинарный минус (вычитание сумм)
    public static Money operator -(Money a, Money b) => new Money(a.Amount - b.Amount);

    // 4. Унарный минус (смена знака суммы)
    public static Money operator -(Money a) => new Money(-a.Amount);

    // 5. Переопределение ToString()
    public override string ToString() => $"{Amount:0.00} руб.";
}

class Program
{
    static void Main(string[] args)
    {
        var m1 = new Money(125.50m);
        var m2 = new Money(50.25m);

        Console.WriteLine($"m1 + m2 = {m1 + m2}"); // 175.50 руб.
        Console.WriteLine($"m1 - m2 = {m1 - m2}"); // 75.25 руб.
        Console.WriteLine($"-m1 = {-m1}");         // -125.50 руб.

        // Проверка автоматически выводимого оператора +=
        m1 += m2;
        Console.WriteLine($"После m1 += m2: {m1}"); // 175.75 руб.
    }
}