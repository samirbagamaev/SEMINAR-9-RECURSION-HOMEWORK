// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = 0;
int m = 5;

int RecN(int n, int m)
{
    if (n == m)
        return n;
    else //RecN(n, m + 1);

     Console.Write($"ЧИСЛО: {RecN(n, m + 1)}  ");

    return m;
}
RecN(m,n);




