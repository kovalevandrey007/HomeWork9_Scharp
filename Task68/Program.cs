/*Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


int GetNumber(string text)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
        Console.WriteLine("Ввели не число или число > или < 0");
        }
    }
    return result;
}

int funAkk(int m, int n)
{ 
    if (m == 0) 
    { 
    return n+1; 
    }
    else if (n==0)
    {
    return funAkk(m-1,1);
    }
    else
    {
    return funAkk(m-1, funAkk(m,n-1)); 
    }
} 

int m = GetNumber("\nВведите число m больше 0:");
int n = GetNumber("\nВведите число n больше m:");
funAkk(m, n);
Console.WriteLine($"\nФункция Аккермана A(m,n) = {funAkk(m, n)}");
