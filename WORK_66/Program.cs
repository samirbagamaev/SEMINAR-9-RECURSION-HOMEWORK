// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//n + SumN(m, n - 1);

int m = 5;
int n = 69;
int SumN(int m, int n)
{
    if (m == n) return n;
    else
    {
       return n + SumN(m, n - 1);
    }
}
SumN(m , n);

Console.WriteLine($"СУММА ОТ {m} до {n} = {SumN(m, n)}");
