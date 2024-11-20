using _1120;
using System.Globalization;


/*
 * Generez aleator elementele unui vector de numere intregi
 */
Random rnd = new Random();
int[] nums;
nums = new int[10];
for (int i = 0; i < nums.Length; i++)
    nums[i] = rnd.Next(100);
PrintArrray(nums, "Original");


InsertionSort(nums);



//for i = 2:n,
//    for (k = i; k > 1 and a[k] < a[k - 1]; k--)
//        swap a[k, k - 1]
//    → invariant: a[1..i] is sorted
//end
void InsertionSort(int[] nums)
{
    for (int i = 1; i < nums.Length; i++)
        for (int k = i; k > 0 && nums[k] < nums[k - 1]; k--)
            (nums[k], nums[k - 1]) = (nums[k - 1], nums[k]);
}

PrintArrray(nums, "Insertion Sort");

SelectionSort(nums);
PrintArrray(nums, "Selection Sort");

/*
 * Bubble Sort
 */



BubbleSort(nums);
PrintArrray(nums, "Bubble sort");




void BubbleSort(int[] nums)
{
    bool sorted;
    do
    {
        sorted = true;
        for (int i = 0; i < nums.Length - 1; i++)
            if (nums[i] > nums[i + 1])
            //(nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);    
            {
                int aux;
                aux = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = aux;
                sorted = false;
            }
    } while (!sorted);
}



//for i = 1:n,
//    k = i
//    for j = i + 1:n, if a[j] < a[k], k = j
//    → invariant: a[k] smallest of a[i..n]
//    swap a[i, k]
//    → invariant: a[1..i] in final position
//end
void SelectionSort(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
    {
        int k = i;
        for (int j = i + 1; j < nums.Length; j++)
            if (nums[j] < nums[k])
                k = j;
        (nums[i], nums[k]) = (nums[k], nums[i]);
    }
}



/*
 * Sortez elementele vectorului in ordine crescatoare dupa valoarea numarului
 * folosind implementarea predefinita Sort din clasa Array.
 */
Array.Sort(nums);
PrintArrray(nums, "Array.Sort");


/*
 * Sortez elementele vectorului in ordine crescatoare dupa suma cifrelor 
 */
Array.Sort(nums, CompareByDigitSum);
PrintArrray(nums, "Sort by sum of digits");



int CompareByDigitSum(int x, int y)
{
    return x.DigitSum() - y.DigitSum();
    //return DigitSumOf(x) - DigitSumOf(y);
}

int DigitSumOf(int x)
{
    if(x == 0) 
        return 0;

    int sum = 0;
    while(x > 0)
    {
        sum += x % 10;
        x = x / 10;
    }
    return sum;
}

static void PrintArrray(int[] nums, string message)
{
    Console.WriteLine(message);
    foreach (int num in nums)
        Console.Write($"{num} ");
    Console.WriteLine();
}








int target, count = 0, sum = 0, times = 1000;


for(int i = 0; i < times; i++)
{
    count = 0;
    do
    {
        target = rnd.Next(100);
        count++;
    }
    while (Array.BinarySearch(nums, target) < 0);
    sum += count;
}
Console.WriteLine(sum / times);


int myBinarySearch(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;
    while(left <= right)
    {
        int mid = left + (right - left) / 2; // mid = (left+right)/2
        if (nums[mid] == target)
            return mid;
        else if (nums[mid] > target)
            right = mid - 1;
        else
            left = mid + 1;
    }
    return -1;
}