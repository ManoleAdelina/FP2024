// RECURSIVITATE

int n = 5;
Console.WriteLine($"{n}! = {factorialR(n)}");
Console.WriteLine($"{n}! = {factorial(n)}");



// In cate moduri se poate ajunge la scorul x-y
int x = 30, y = 30;
Dictionary<(int x, int y), long> memo = new();
Console.WriteLine($"{x}-{y} = {Scor(x, y)}");



// Se da un numar n. In cate moduri poate fi scris n ca suma de 1,2,3
n = 10;
Console.WriteLine($"{S123(n)}");
// 1, 2, 4, 7, 13 ,24, .... 



// Algoritmul Euclid determina cel mai mare divizor comun a doua numere
// (15, 35) = 5
// (100, 70) = 10

x = 100;
y = 70;
Console.WriteLine($"({x}, {y}) = {gcd(x, y)}");
Console.WriteLine($"({x}, {y}) = {gcd2(x, y)}");


//(105, 75) = (75, 30) = (30, 15) = (15, 0)
// 142 : 15
int gcd2(int x, int y)
{
	if (y == 0)
		return x;
	else
		return gcd2(y, x % y);
}

x = 105;
y = 75;
Console.WriteLine($"({x}, {y}) = {gcd(x, y)}");
Console.WriteLine($"({x}, {y}) = {gcd2(x, y)}");

int gcd(int x, int y)
{
	if (x == y)
		return x;
	if (x > y)
		return gcd(x - y, y);
	else
		return gcd(x, y - x);
}

int S123(int n)
{
    if (n == 1) return 1;
	if (n == 2) return 2;
	if (n == 3) return 4;
	return S123(n-1) + S123(n - 2) + S123(n - 3);
}

//Memoization
long Scor(int x, int y)
{
	if (x > y)
		(x, y) = (y, x);

	if (memo.Keys.Contains((x, y)))
		return memo[(x, y)];

	if (x == 0 || y == 0)
		return 1;
	
	long r = Scor(x - 1, y) + Scor(x, y - 1); 
	memo.Add((x, y), r);
	return r;
}

// n! = 1 daca n = 0, n * (n - 1)! daca n > 0
int factorialR(int n)
{
	if (n == 0)
		return 1;
	else
		return n * factorialR(n - 1);
}



// n! = 1*2*...*n
// 4! = 1*2*3*4 = 24
int factorial(int n)
{
    int produs = 1;
	for (int i = 1; i <= n; i++)
	{
		produs *= i;
	}
	return produs;
}