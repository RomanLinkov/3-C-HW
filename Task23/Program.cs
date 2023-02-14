using System;
using static System.Console;

Clear();

WriteLine("Введите число N:");
int N=int.Parse(ReadLine());

WriteLine($"Таблица кубов числа {N}:");
for (int i=1; i<=N;i++)
{
    Write($"{Math.Pow(i,3)}");
    if (i<N) {Write(", ");};
}
WriteLine();