DateTime azi = DateTime.Now;
DateTime maine = azi.AddDays(1);
Console.WriteLine(azi);
Console.WriteLine(azi.Hour);
Console.WriteLine(azi.AddHours(42));
Console.WriteLine(azi.ToShortDateString());
Console.WriteLine(azi.ToShortTimeString());
Console.WriteLine(maine.Subtract(azi).TotalHours);
Console.WriteLine(maine.Subtract(azi).TotalMinutes);


int a1 = 2024, l1 = 11, z1 = 13;
int a2 = 2006, l2 = 5, z2 = 28;

Console.WriteLine($"Numarul de zile dintre cele doua date este {DaysDiff((a1, l1, z1), (a2, l2, z2))}");

int DaysDiff((int a, int l, int z) date1, (int a, int l, int z) date2)
{
    int result = 0;

    while(!(date1.a == date2.a && date1.l == date2.l && date1.z == date2.z))
    {
        result++;
        // scad o zi din date1
        if (date1.z > 1)
            date1.z--;
        else
        {
            switch (date1.l)
            {
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    date1.z = 31;
                    date1.l--;
                    break;
                case 1:
                    date1.z = 31;
                    date1.l = 12;
                    date1.a--;
                    break;
                case 3:
                    date1.z = 28;
                    if (bisect(date1.a))
                        date1.z++;
                    date1.l--;
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    date1.z = 30;
                    date1.l--;
                    break;
            }
        }
    }
    

    return result;
}

bool bisect(int a)
{
    return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
}