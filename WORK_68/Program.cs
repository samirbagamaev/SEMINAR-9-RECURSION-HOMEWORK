// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

//Функция Аккермана:///////////////////////////////////////////////
//                                                               //
//       {2}   { n + 1                {1}  m = 0                 //          
//   A(m,n) =  { A(m -1, 1) {4}       {3}  m > 0, n = 0          //
//       {5}   { A(m - 1,  A(m -1, 1))     m  > 0, n > 0         //
//                                                               //
///////////////////////////////////////////////////////////////////

int m = 5;
int n = 69;

int AkkermansFunction(int m, int n )
{
  if (m == 0)
  return n + 1;
  
  if (m > 0 && n == 0 )
  return AkkermansFunction(m - 1, 1);
  else 
  return AkkermansFunction(m - 1,  AkkermansFunction(m - 1, 1));
}
AkkermansFunction(m , n);
Console.WriteLine($"ФУНКЦИЯ АККЕРМАНА ДЛЯ ЗНАЧЕНИЙ {m} и {n} РАВНЯЕТСЯ {AkkermansFunction(m , n)}");