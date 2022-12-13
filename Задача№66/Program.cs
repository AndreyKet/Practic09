// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.Write(SumNaturNumber(m - 1, n));

int SumNaturNumber(int m, int n)
{
    if (m == n) return 0;
    
    m++;
    return m + SumNaturNumber(m, n);   
}