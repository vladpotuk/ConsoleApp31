using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        // Завдання 4 - Місто
        City city = new City();
        Console.WriteLine("Завдання 4 - Місто");
        city.InputData();
        Console.WriteLine("Введені дані про місто:");
        city.DisplayData();
        Console.WriteLine();

        // Завдання 5 - Співробітник
        Employee employee = new Employee();
        Console.WriteLine("Завдання 5 - Співробітник");
        employee.InputData();
        Console.WriteLine("Введені дані про співробітника:");
        employee.DisplayData();
        Console.WriteLine();

        // Завдання 6 - Літак
        Plane plane = new Plane("Boeing 747", "Boeing", 2020, "Passenger");
        Console.WriteLine("Завдання 6 - Літак");
        Console.WriteLine("Введені дані про літак:");
        plane.DisplayData();
        Console.WriteLine();

        // Завдання 7 - Матриця
        Console.WriteLine("Завдання 7 - Матриця");
        Console.Write("Введіть кількість рядків матриці: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців матриці: ");
        int columns = int.Parse(Console.ReadLine());

        Matrix matrix = new Matrix(rows, columns);
        matrix.InputData();

        Console.WriteLine("Введені дані матриці:");
        matrix.DisplayData();
        Console.WriteLine($"Максимальний елемент матриці: {matrix.FindMaximum()}");
        Console.WriteLine($"Мінімальний елемент матриці: {matrix.FindMinimum()}");
    }
}
