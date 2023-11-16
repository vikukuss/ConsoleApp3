using System;

class Program
{
    static void Main(string[] args)
    {
        double x0 = 0; // Начальное приближение корня
        double epsilon = 1e-3; // Требуемая точность

        double x1 = x0 - f(x0) / fDerivative(x0); // Вычисляем первое значение x1

        while (Math.Abs(x1 - x0) > epsilon)
        {
            x0 = x1;
            x1 = x0 - f(x0) / fDerivative(x0);
        }

        Console.WriteLine("Корень уравнения: " + x1);
    }

    // Функция уравнения f(x) = lg(x+5) - cos(x)
    static double f(double x)
    {
        return Math.Log(x + 5) - Math.Cos(x);
    }

    // Производная функции уравнения f(x)
    static double fDerivative(double x)
    {
        return 1 / (x + 5) + Math.Sin(x);
    }
}

