/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов 
 в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

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

int Value(int m, int n)
 { 
    
    if (n == m) 
    { 
        return m; 
        }
        else 
        {
        return Value(m + 1, n - 1) + m + n; 
    } 
}

int m = GetNumber("\nВведите число m больше 0:");
int n = GetNumber("\nВведите число n больше m:");
Value(m, n);
Console.WriteLine($"\nСумма всех чисел от m до n = {Value(m, n)}");
