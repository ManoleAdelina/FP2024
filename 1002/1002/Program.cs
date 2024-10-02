// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


for (int i = 1; i <= 1000; i++)
    f(i);

void f(int n)
{
    Console.Write($"{n} ");

    while ( n > 1 )
    {
        if (n % 2 == 0)
            n = n / 2;
        else
            n = 3 * n + 1;
        Console.Write($"{n} ");
    }

    Console.WriteLine();
}