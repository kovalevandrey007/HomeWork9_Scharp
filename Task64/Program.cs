﻿/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

static int Rev(int n)
{
    if (n == 1)
    {
    return 1;
    }
    else
    {
    Console.Write("{0},", n) ;
    Rev(n - 1);
    return n;
    }
}

int n = GetNumber("Введите число больше 1");
Rev(n);
Console.WriteLine(Rev(n));