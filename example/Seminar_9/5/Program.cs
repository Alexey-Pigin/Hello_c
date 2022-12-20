



//   task 69

int rec(int n, int m)
{
    if (m == 0)
        return 1;
    return rec(n, m - 1) * n;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));