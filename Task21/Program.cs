using System;
using static System.Console;

Clear();

WriteLine("Введите координаты точки А последовательно xa ya za:");
int xa=int.Parse(ReadLine());
int ya=int.Parse(ReadLine());
int za=int.Parse(ReadLine());

WriteLine("Введите координаты точки B последовательно xa ya za:");
int xb=int.Parse(ReadLine());
int yb=int.Parse(ReadLine());
int zb=int.Parse(ReadLine());

int SquareDiff(int x1, int x2)
{
    int sq = (x2 - x1)*(x2 - x1);
    return sq;
}

double Distance = Math.Sqrt(SquareDiff(xa, xb) + SquareDiff(ya, yb) + SquareDiff(za, zb));
Distance = Math.Round(Distance, 2);

WriteLine($"Расстояние между A и B = {Distance}");
