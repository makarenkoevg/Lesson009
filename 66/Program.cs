// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();


Write("Введите целое полижительное M: ");
int m = int.Parse(ReadLine());

Write("Введите целое полижительное N: ");
int n = int.Parse(ReadLine());


int Summ(int a, int b)
{
    if (b==a)
    {
        return a;
    }
    return (Summ(a,b-1) + b);
}

if (n>m){
    WriteLine(Summ(m,n));
}
