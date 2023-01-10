/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (?)
m = 3, n = 2 -> A(m,n) = 29 (?)
*/

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akker(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Akker(m - 1, Akker(m, n - 1));
    } 
    else
    {
       return n + 1; 
    }
    
}


Console.WriteLine(Akker(2, 3));
Console.WriteLine(Akker(3, 2));
