/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов 
 в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result>1)
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

int Sum(int number)
{
    int result = 0;
    if (number < 10)
    {
        result = number;
    }
    else
    {
        result = Sum(number / 10) + number % 10;
    }
    return result;
}