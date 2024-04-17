using System;

class Rational
{
    private int numerator;
    private int denominator;

    public Rational(int a, int b)
    {
        int gcd = GCD(a, b);
        numerator = a / gcd;
        denominator = b / gcd;
    }

    public static Rational operator +(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }

    public static Rational operator -(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.denominator - r2.numerator * r1.denominator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }

    public static Rational operator *(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.numerator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }

    public static Rational operator /(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.denominator;
        int newDenominator = r1.denominator * r2.numerator;
        return new Rational(newNumerator, newDenominator);
    }

    public static bool operator ==(Rational r1, Rational r2)
    {
        return r1.numerator == r2.numerator && r1.denominator == r2.denominator;
    }

    public static bool operator !=(Rational r1, Rational r2)
    {
        return !(r1 == r2);
    }

    private static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
}

class Program
{
    static void Main()
    {
    T1: Console.WriteLine("Введите числитель первой дроби:");
        if (int.TryParse(Console.ReadLine(), out int a1))
        { }
        else
        {
            Console.WriteLine("Введено некоректное значение");
            goto T1;
        }

    T2: Console.WriteLine("Введите знаменатель первой дроби:");
        if (int.TryParse(Console.ReadLine(), out int b1) && b1 != 0)
        { }
        else
        {
            Console.WriteLine("Введено некоректное значение");
            goto T2;
        }

    T3: Console.WriteLine("Введите числитель второй дроби:");
        if (int.TryParse(Console.ReadLine(), out int a2))
        { }
        else
        {
            Console.WriteLine("Введено некоректное значение");
            goto T3;
        }

    T4: Console.WriteLine("Введите знаменатель второй дроби:");
        if (int.TryParse(Console.ReadLine(), out int b2) && b2 != 0)
        { }
        else
        {
            Console.WriteLine("Введено некоректное значение");
            goto T4;
        }


        Rational r1 = new Rational(a1, b1);
        Rational r2 = new Rational(a2, b2);

        Console.WriteLine($"r1: {r1}");
        Console.WriteLine($"r2: {r2}");

        Rational sum = r1 + r2;
        Console.WriteLine($"Сумма: {sum}");

        Rational difference = r1 - r2;
        Console.WriteLine($"Разность: {difference}");

        Rational product = r1 * r2;
        Console.WriteLine($"Произведение: {product}");

        Rational quotient = r1 / r2;
        Console.WriteLine($"Частное: {quotient}");

        Console.WriteLine($"r1 == r2: {r1 == r2}");
        Console.WriteLine($"r1 != r2: {r1 != r2}");
    }
}