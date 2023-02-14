using System;
using static System.Console;

Clear();

WriteLine("Введите число N:");
String Number1=ReadLine();
int length=Number1.Length;

int[] array = new int[length];
int i=0;
WriteLine($"длина {length}");
WriteLine(Number1[2]);

int k = int.Parse(Number1[1]);
WriteLine(k);

