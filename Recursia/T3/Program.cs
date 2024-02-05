using System;

class Program
{
    static int[] m = {1, 2, 5, 0, 10, 34};

    static void Main(string[] args)
    {
        F(m.Length - 1);
    }

    static void F(int a)
    {
        if (a < 0)
        {
            return;
        }
        else
        {
            Console.Write(m[a]);
            F(a - 1);
        }
    }
}