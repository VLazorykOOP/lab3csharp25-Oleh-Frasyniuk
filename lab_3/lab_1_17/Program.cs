using System;

public class Trapeze
{
    // Поля
    private int a; // довжина першої основи
    private int b; // довжина другої основи
    private int h; // висота трапеції
    private int c; // колір трапеції

    // Конструктор
    public Trapeze(int a, int b, int h, int c)
    {
        this.a = a;
        this.b = b;
        this.h = h;
        this.c = c;
    }

    // Властивості для доступу до полів
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int H
    {
        get { return h; }
        set { h = value; }
    }

    public int C
    {
        get { return c; }
    }

    // Метод для виведення довжин на екран
    public void DisplayDimensions()
    {
        Console.WriteLine($"Основа 1: {a}, Основа 2: {b}, Висота: {h}, Колір: {c}");
    }

    // Метод для обчислення периметра трапеції
    public double CalculatePerimeter()
    {
        double side = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((a - b) / 2.0, 2));
        return a + b + 2 * side;
    }

    // Метод для обчислення площі трапеції
    public double CalculateArea()
    {
        return ((a + b) / 2.0) * h;
    }

    // Метод для перевірки чи є трапеція квадратом
    public bool IsSquare
    {
        get { return a == b && h == a; }
    }

    // Статичний метод для підрахунку кількості квадратів у масиві трапецій
    public static int CountSquares(Trapeze[] trapezes)
    {
        int count = 0;
        foreach (var trapeze in trapezes)
        {
            if (trapeze.IsSquare)
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main()
    {
        // Створюємо масив трапецій
        Trapeze[] trapezes = new Trapeze[]
        {
            new Trapeze(5, 5, 5, 1),
            new Trapeze(10, 10, 10, 2),
            new Trapeze(5, 7, 4, 3),
            new Trapeze(3, 5, 4, 4)
        };

        // Виводимо інформацію про трапеції, їх площу, периметр
        foreach (var trapeze in trapezes)
        {
            trapeze.DisplayDimensions();
            Console.WriteLine($"Периметр: {trapeze.CalculatePerimeter():F2}");
            Console.WriteLine($"Площа: {trapeze.CalculateArea():F2}");
            Console.WriteLine($"Чи є квадратом: {trapeze.IsSquare}");
            Console.WriteLine();
        }

        // Підраховуємо скільки трапецій є квадратами
        int squareCount = Trapeze.CountSquares(trapezes);
        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}

