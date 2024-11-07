//Sort3();

// Teste de primalitate
int n = 1000000007;
// ~2^1024+1
(bool result, int div) = Prime4(n);


// Miller-Rabin - test de primalitate probabilistic
(bool result, int div) Prime4(int n)
{
    // TODO: implementati testul de primalitate Miller-Rabin.
    throw new NotImplementedException();
}

(bool result, int div) Prime3(int n)
{
    if (n < 2)
        return (false, 0);
    if (n == 2 || n == 3)
        return (true, 0);
    if (n % 2 == 0 || n % 3 == 0)
        return (false, 0);

    for (int d = 5; d * d <= n; d += 6)
        if (n % d == 0)
            return (false, d);
        else if (n % (d + 2) == 0)
            return (false, d + 2);

    return (true, 0);
}

(bool result, int div) Prime2(int n)
{
    if (n < 2)
        return (false, 0);
    if (n == 2)
        return (true, 0);
    if (n % 2 == 0)
        return (false, 0);

    for (int d = 3; d * d <= n; d += 2)
        if (n % d == 0)
            return (false, d);

    return (true, 0);
}

Console.WriteLine($"{n} este prim? {result} / Div = {div}");

(bool, int) Prime1(int n)
{
    if (n < 2)
        return (false, 0);
    if (n == 2)
        return (true, 0);
    if (n % 2 == 0)
        return (false, 0);

    for (int d = 3; d <= n / 2; d += 2)
        if (n % d == 0)
            return (false, d);

    return (true, 0);
}

static void Sort3()
{
    int a, b, c;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());

    //int minim = a;
    //if(b < minim)
    //    minim = b;
    //if(c < minim)
    //    minim = c;
    int minim = Math.Min(a, Math.Min(b, c));


    //int maxim = a;
    //if(b > maxim)
    //    maxim = b;
    //if(c > maxim)
    //    maxim = c;

    int maxim = Math.Max(a, Math.Max(b, c));

    int median = (a + b + c) - (minim + maxim);
    Console.WriteLine($"{minim} {median} {maxim}");
}