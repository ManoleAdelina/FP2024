// Matrici

string text = File.ReadAllText("input.txt");
string[] t = text.Split("\r\n\r\n");

int[,] m1, m2;

m1 = ParseMatrix(t[0]);
m2 = ParseMatrix(t[1]);


PrintMatrix(m1, "m1");
PrintMatrix(m2, "m2");


// TODO: parcurgerea unei matrici in spirala
//Spirala(m1);

// Matrici patratice
// TODO:
// Suma elementelor de pe diagonala principala (i == j)
// Suma elementelor de pe diagonala secundara (i+j == n - 1)
// Suma elementelor de deasupra diagonalei principale (i < j)
// Suma elementelor de sub diagonala principala
// Suma elementelor de deasupra diagonalei secundare
// Suma elementelor de sub diagonala secundare
// Suma elementelor din zona de Nord a matricii
// Suma elementelor din zona de Sub a matricii
// Suma elementelor din zona de Est a matricii
// Suma elementelor din zona de Vest a matricii

// Parcurgere pe diagonala
//4 4
//1  3  4 10
//2  5  9 11
//6  8 12 15
//7 13 14 16
// se va afisa: 1 2 3 ... 16

// Parcurgere concentrica
// 1  2  9 10
// 4  3  8 11
// 5  6  7 12
//16 15 14 13
//  se va afisa: 1 2 3 ... 16

try
{
    int[,] m3 = Multiply(m1, m2);
    PrintMatrix(m3, "m1 * m2");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}



int[,] Multiply(int[,] m1, int[,] m2)
{
    if (m1.GetLength(1) != m2.GetLength(0))
        throw new ArgumentException("Matricile nu pot fi inmultite pentru  ca numarul de linii al primei matrici este diferit de numarul de coloane al celei de a doua matrici");
    int[,] m = new int[m1.GetLength(0), m2.GetLength(1)];
    for(int i = 0; i < m.GetLength(0); i++)
        for(int j = 0; j < m.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < m1.GetLength(1); k++)
                sum += m1[i, k] * m2[k, j];
            m[i, j] = sum;
        }

    return m;
}
void PrintMatrix(int[,] m, string v)
{
    Console.WriteLine(v);
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength(1); j++)
            Console.Write($"{m[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] ParseMatrix(string v)
{
    string[] t = v.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
    string[] dim = t[0].Split(" ");
    int LIN, COL;
    LIN = int.Parse(dim[0]);
    COL = int.Parse(dim[1]);
    int[,] mat = new int[LIN, COL];
    for(int i = 0; i < LIN; i++)
    {
        string[] values = t[i + 1].Split(" ");
        for(int j = 0; j < COL; j++)
            mat[i, j] = int.Parse(values[j]); 
    }
    return mat;

}