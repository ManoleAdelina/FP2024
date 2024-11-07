// VerificarePalindrom();
// Divizori();
// Coins();

#region Divizori
void Divizori()
{
    int n = 180;
    // suma divizorilor
    Console.WriteLine($"suma divizorilor lui {n} este {SumaDivizori(n)}");
    // numarul de divizori
}

int SumaDivizori1(int n)
{
    int suma = 0;
    for (int d = 1; d <= n; d++)
        if (n % d == 0)
            suma += d; // suma = suma + d; 
    return suma;
}

int SumaDivizori2(int n)
{
    if(n == 1) return 1;

    int suma = 1 + n;
    for (int d = 2; d <= n / 2; d++)
        if (n % d == 0)
            suma += d; // suma = suma + d; 
    return suma;
}

int SumaDivizori3(int n)
{
    if (n == 1) return 1;

    int suma = 1 + n;
    int d = 0;
    for (d = 2; d * d < n; d++)
        if (n % d == 0)
            suma += d + n / d; // suma = suma + d; 
    if (d * d == n)
        suma += d;
    return suma;
}

// TODO: implementare mai rapida decat cele de mai sus ^^^
int SumaDivizori(int n)
{
    throw new NotImplementedException();
}
#endregion

#region Palindrom
bool Palindrom(int number)
{
    return number == Oglindit(number);
}

// Oglindit(123) => 321
// Oglindit(1200) => 21
int Oglindit(int number)
{
    int result = 0;
    while (number > 0)
    {
        int cifra = number % 10;
        number = number / 10;
        result = result * 10 + cifra;
    }

    return result;
}

void VerificarePalindrom()
{
    string line = Console.ReadLine();
    char[] sep = { ' ', '\t', ';', ',', '.' };
    // 23  56
    string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
    foreach (string token in tokens)
    {
        try
        {
            int number = int.Parse(token);
            if (Palindrom(number))
                Console.WriteLine($"{number} este palindrom");
            else
                Console.WriteLine($"{number} nu este palindrom");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
#endregion

#region Game
static void Coins()
{
    int stake;
    int goal;
    int times = 10000;
    int wins = 0, losses = 0;


    Random rnd = new Random();

    for (int i = 1; i <= times; i++)
    {
        stake = 70;
        goal = 100;

        while (!(stake == 0 || goal == stake))
            if (rnd.Next(2) == 0)
                stake++;
            else
                stake--;

        if (stake == 0)
            losses++;
        else if (stake == goal)
            wins++;
    }

    Console.WriteLine($"Wins: {wins}, Losses: {losses}");
}
#endregion