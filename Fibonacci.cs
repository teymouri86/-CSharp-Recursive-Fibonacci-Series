using System;

class Program
{
    // متد بازگشتی برای فیبوناچی
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.Write("یک عدد وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nسری فیبوناچی تا عدد " + n + ":");

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.WriteLine();
    }
}
