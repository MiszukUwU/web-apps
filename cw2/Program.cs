﻿void cw1(){
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Liczba {a} do potęgi wynosi {a*a}");
}

void cw2()
{
    int a, b;
    Console.WriteLine("Podaj a: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj b: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} * {b} = {a * b}");
    if (b != 0)
        Console.WriteLine($"{a} / {b} = {(float)a / b}");
    else
        Console.WriteLine($"{a} / {b} = BRAK WYNIKU");
}
// cw1();
cw2();