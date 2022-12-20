

// task 67


int rec(int n)
{
    if (n % 10 == n || n < 10 || n / 10 == 0)
        return n;
    return rec(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));