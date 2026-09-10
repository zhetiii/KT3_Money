using System;

// Выполнение программы (Top-Level Statements)
var m1 = new Money(125.50m);
var m2 = new Money(50.25m);

Console.WriteLine($"m1 + m2 = {m1 + m2}");
Console.WriteLine($"m1 - m2 = {m1 - m2}");
Console.WriteLine($"-m1 = {-m1}");

m1 += m2;
Console.WriteLine($"После m1 += m2: {m1}");

// Класс Money
public class Money
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    public static Money operator +(Money a, Money b) => new Money(a.Amount + b.Amount);
    public static Money operator -(Money a, Money b) => new Money(a.Amount - b.Amount);
    public static Money operator -(Money a) => new Money(-a.Amount);

    public override string ToString() => $"{Amount:0.00} руб.";
}