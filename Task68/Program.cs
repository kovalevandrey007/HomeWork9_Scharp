/*Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 1)
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
int Value(int A, int B)
 { 
    
    if (B == 1) 
    { 
        return A; 
        }
         else 
        {
             return Value(A, B - 1) * A; } 
}
Console.WriteLine(Value(GetNumber("Введите число A"), GetNumber("B")));