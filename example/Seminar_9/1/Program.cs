





int sum(int n, int m)
{
    if (m == 0)
        return n;
    return sum(n + 1, m - 1);
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n, m));


int sum()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
        return 0;
    return sum() + x;
}

Console.Clear();
Console.WriteLine(sum());



void sum(int res)
{
    Console.WriteLine(1);
    int x = Convert.ToInt32(Console.ReadLine());
    res += x;
    if (x == 0)
        Console.WriteLine(res);
    if (x != 0)
        sum(res);
}

int res = 0;
Console.Clear();
sum(res);