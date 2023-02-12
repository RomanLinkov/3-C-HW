using System;
using static System.Console;

Clear();

WriteLine("Введите координаты точки А последовательно Xa Ya Za:");
int Xa=int.Parse(ReadLine());
int Ya=int.Parse(ReadLine());
int Za=int.Parse(ReadLine());

WriteLine("Введите координаты точки B последовательно Xa Ya Za:");
int Xb=int.Parse(ReadLine());
int Yb=int.Parse(ReadLine());
int Zb=int.Parse(ReadLine());

int SquareDiff(int x1, int x2)
{
    int SQ = (x2 - x1)*(x2 - x1);
    return SQ;
}

double Distance = Math.Sqrt(SquareDiff(Xa, Xb) + SquareDiff(Ya, Yb) + SquareDiff(Za, Zb));
Distance = Math.Round(Distance, 2);

WriteLine($"Расстояние между A и B = {Distance}");
