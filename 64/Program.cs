// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1(судя по примеру от M до N). Выполнить с помощью рекурсии.

// M = 5; N = 3 -> "5, 4, 3"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"

using System;
using static System.Console;

Clear();


Write("Введите целое полижительное M: ");
int m = int.Parse(ReadLine());

Write("Введите целое полижительное N: ");
int n = int.Parse(ReadLine());


void PrintNumber(int a, int b)
{
    if (a>=b)
    {
        Write($"{a} ");
        PrintNumber(a-1,b);
    }
}

if (m>n) {
    PrintNumber(m,n);
    }

