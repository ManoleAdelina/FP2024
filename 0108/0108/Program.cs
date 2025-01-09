// part1();

using System.CodeDom.Compiler;

static void part1()
{
    int[] nums = { 1, 3, 5, 2, 1, 4, 2, 9, 8 };


    // ******************************************
    // LINQ = Language Integrated Query
    Console.WriteLine("LINQ");
    var result = nums.Distinct().ToList();
    result.Sort();
    foreach (var item in result)
        Console.WriteLine(item);

    Console.WriteLine($"Maxim: {result.Max()}");
    Console.WriteLine($"Minim: {result.Min()}");
    Console.WriteLine($"Numar pare: {result.Count(x => x % 2 == 0)}");



    // **********************************
    Console.WriteLine(new String('*', 20));
    Console.WriteLine("HashSet");
    HashSet<int> set1 = new HashSet<int>(nums);
    Console.WriteLine($"Count: {set1.Count}");

    int[] nums2 = { 1, 3, 5, 3, 7, 7, 7, 8 };
    HashSet<int> set2 = new HashSet<int>();

    foreach (var item in nums2)
        set2.Add(item);

    Console.WriteLine(string.Join(", ", set2));


    // ******************************
    // vreau ca lst sa contina elementele unice din vectorul nums
    Console.WriteLine(new String('*', 20));

    List<int> lst = null;
    lst = Distinct(nums);
    lst.Sort();
    Console.WriteLine(string.Join(", ", lst));

    List<int> Distinct(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
            if (!result.Contains(nums[i]))
                result.Add(nums[i]);
        return result;
    }


    // *******************************
    Console.WriteLine(new String('*', 20));
    int[] distinctNums = DistinctArray(nums);
    Console.WriteLine(string.Join(", ", distinctNums));



    int[] DistinctArray(int[] nums)
    {
        int[] result = new int[nums.Length];
        int cnt = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            bool found = false;
            for (int j = 0; !found && j < cnt; j++)
                if (nums[i] == result[j])
                    found = true;
            if (!found)
                result[cnt++] = nums[i];

        }

        int[] r2 = new int[cnt];
        Array.Copy(result, r2, cnt);



        //return result.Take(cnt).ToArray();

        return r2;
    }
}

// Se da o multime. Se cere sa se afiseze toate submultimile ei.
// A = {a, b, c}
// S = {{}, {a}, {b}, {c}, {a,b}, {a,c}, {b,c}, {a,b,c}}


List<int> A = new List<int>() { 1, 2, 3, 4, 5 };

Submultimi1(A);

static void Submultimi1(List<int> A)
{
    List<List<int>> S = new List<List<int>>();

    Generate(new List<int>(), A.Count, 0);

    foreach (var item in S)
        Console.WriteLine(string.Join(", ", item));


    void Generate(List<int> list, int count, int depth)
    {
        if (depth == count)
            S.Add(list);
        else
        {
            //List<int> lst1 = new List<int>(list);
            List<int> lst2 = new List<int>(list);

            Generate(list, count, depth + 1);

            lst2.Add(A[depth]);
            Generate(lst2, count, depth + 1);
        }
    }
}


//Submultimi2(A);

// A = {a, b, c}
// 000 => {}
// 001 => {c}
// 010 => {b}
// 011 => {b, c}
// 100 => {a}
// 101 => {a, c}
// 110 => {a, b}
// 111 => {a, b, c}
void Submultimi2(List<int> A)
{
    List<List<int>> S = new List<List<int>>();
    int N = (int)Math.Pow(2, A.Count);
    for(int n = 0; n < N; n++)
    {
        string bits = Convert.ToString(n, 2).PadLeft(A.Count, '0');
        List<int> lst = new List<int>();
        for(int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '1')
                lst.Add(A[i]);
        }
        Console.WriteLine(string.Join(", ", lst));
    }
}