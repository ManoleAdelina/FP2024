int[] v = { 3, 6, 2, 1, 5, 7, 2, 4, 1, 9 };
int C = 10; // capacitatea unui container
PrintArray(v);
// algoritmi online // offline
Console.WriteLine($"NextFit: {NextFit(v, C)}");
Console.WriteLine($"FirstFit: {FirstFit(v, C)}");
Console.WriteLine($"BestFit: {BestFit(v, C)}");
Console.WriteLine($"WorstFit: {WorstFit(v, C)}");

Array.Sort(v);
PrintArray(v);

void PrintArray(int[] v)
{
    foreach(var item in v)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"NextFitIncreasing: {NextFit(v, C)}");
Console.WriteLine($"FirstFitIncreasing: {FirstFit(v, C)}");
Console.WriteLine($"BestFitIncreasing: {BestFit(v, C)}");
Console.WriteLine($"WorstFitIncreasing: {WorstFit(v, C)}");

Array.Sort(v, (x, y) => y - x);
PrintArray(v);
Console.WriteLine($"NextFitDecreasing: {NextFit(v, C)}");
Console.WriteLine($"FirstFitDecreasing: {FirstFit(v, C)}");
Console.WriteLine($"BestFitDecreasing: {BestFit(v, C)}");
Console.WriteLine($"WorstFitDecreasing: {WorstFit(v, C)}");

//3, 6, 2, 1, 5, 7, 2, 4, 1, 9
//List: 10, 10, 7
// 3 6 1
// 2 5 2 1
// 7
// 4
// 9

int BestFit(int[] v, int C)
{
    List<int> bins = new List<int>();
    bins.Add(0);

    foreach(var item in v)
    {
        bool found = false;
        int maxim = 0;
        int binIndex = 0; 
        for(int i = 0; i < bins.Count; i++)
        {
            if (bins[i] + item <= C) 
            { 
                found = true;
                if (bins[i] + item > maxim)
                {
                    binIndex = i;
                    maxim = bins[i] + item;
                }
            }
        }
        if (found)
            bins[binIndex] += item;
        else
            bins.Add(item);
    }

    return bins.Count;

}


int WorstFit(int[] v, int C)
{
    List<int> bins = new List<int>();
    bins.Add(0);

    foreach (var item in v)
    {
        bool found = false;
        int minim = C;
        int binIndex = 0;
        for (int i = 0; i < bins.Count; i++)
        {
            if (bins[i] + item <= C)
            {
                found = true;
                if (bins[i] + item < minim)
                {
                    binIndex = i;
                    minim = bins[i] + item;
                }
            }
        }
        if (found)
            bins[binIndex] += item;
        else
            bins.Add(item);
    }

    return bins.Count;
}


//3, 6, 2, 1, 5, 7, 2, 4, 1, 9
//List: 10, 10, 7, 4, 
// 3 6 1
// 2 5  2 1
// 7
// 4
// 9
int FirstFit(int[] v, int C)
{
    List<int> bins = new List<int>();
    bins.Add(0);

    for (int i = 0; i < v.Length; i++)
    {
        // gasesc primul bin din lista celor deschise in care as putea sa il pun pe v[i]
        bool found = false;
        for(int j = 0; j < bins.Count; j++)
        {
            if (v[i] + bins[j] <= C)
            {
                found = true;
                bins[j] += v[i];
            }
        }
        if(!found)
        {
            bins.Add(v[i]);
        }
    }
    return bins.Count;
}



// 3, 6, 2, 1, 5, 7, 2, 4, 1, 9
// 3 6 
// 2 1 5 
// 7 2
// 4 1 
// 9
int NextFit(int[] v, int C)
{
    int numBins = 1;
    int currentBin = 0;
    for(int i = 0; i < v.Length; i++)
    {
        if (currentBin + v[i] <= C)
            currentBin += v[i];
        else
        {
            numBins++;
            currentBin = v[i];
        }
    }
    return numBins;
}