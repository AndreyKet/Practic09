﻿// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
NaturNumber(number);

void NaturNumber(int number)
{
    if (number != 0)
    {
        Console.Write(number + " ");
        NaturNumber(number - 1);
    }
}