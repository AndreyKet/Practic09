// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.Write(Ack(m, n));

int Ack(int m, int n)
{
    if (m == 0)
    return n + 1;

    if (n == 0) 
    return Ack(m - 1, 1);

    else 
    return Ack(m - 1, Ack(m, n - 1));
}