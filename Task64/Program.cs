using System.Linq;
/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

//функция проверки на положительное число
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или меньше 1. Введите положительное число ");
        }
    }
    return result;
}

string GetValues(int n)
{
    if (n > 1)
    {
        return n.ToString();
    }
     return GetValues (n-1) + $", {n}";
}

int n = GetNumber("Введите число больше 1");

GetValues(n);
Console.WriteLine(GetValues(n));








