using System;

class Program
{
static void Main()
{
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана = {Ackerman(m, n)} ");
}
static int Ackerman(int m, int n)
{
  if (m == 0) 
  return n + 1;
  else
  if (n == 0) 
  return Ackerman(m - 1, 1);
  else
  return Ackerman(m - 1, Ackerman(m, n - 1));
}
}