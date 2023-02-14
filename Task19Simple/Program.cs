using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
String number1=ReadLine();
int length=number1.Length;

int i=0;
int b=length/2;
bool w=true;
while (i<b)
{
    if (number1[i] != number1[length-1-i]) 
    {
        Write("Введённое число не является палиндромом "); 
        w=false; 
        break;
    } 
    i++;
} 
if (w) WriteLine("Введенное число является палиндромом");
WriteLine();