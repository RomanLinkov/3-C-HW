using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
String Number1=ReadLine();
int length=Number1.Length;

int[] array = new int[length];
int k = Convert.ToInt32(Number1);
int i=0;

while (i<length) 
{
    array[i]=k%10;
    k=k/10;
    i++;
}

i=0;
int b=length/2;
bool w=true;

while (i<b)
{
    if (array[i] != array[length-1-i]) 
    {
        Write("Введённое число не является палиндромом "); 
        w=false; 
        break;
    } 
    i++;
} 
if (w) WriteLine("Введенное число является палиндромом");
WriteLine();