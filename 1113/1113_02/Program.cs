// Tablouri/vectori

int[] arr;
arr = InitArray(10);
PrintArray(arr);

int[] arr1 = InitRandomArray(10, 1000);
PrintArray(arr1);


int[] arr2 = InitRandomArray2(10, 1000, 10000);
PrintArray(arr2);



// Generez un vector cu un milion de elemente ale 
// caror valori sunt cuprinse intre 0 si 99
int[] arr3 = InitRandomArray(1000000, 100);
int[] f = Frequency(arr3, 100);

int[] Frequency(int[] arr, int maxValue)
{
    int[] f = new int[maxValue];
    for (int i = 0; i < arr.Length; i++)
        f[arr[i]]++;
    return f;
}

PrintArray(f);

int[] InitRandomArray2(int n, int start, int end)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(start, end);
    return arr;
}



int[] InitRandomArray(int n, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(maxValue); 
    return arr;
}



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] InitArray(int n)
{
    return new int[n];
}