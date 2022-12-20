
//   tast 63


int rec(int n)
{
    if (n==1)
    {
        return 1;
    }
    return rec(n-1) +n;
}


System.Console.WriteLine("press num");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(rec(n));


string rec(int n)
{
    if (n == 1)
        return "1 ";
    return rec(n - 1) + $"{n} ";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));


void rec(int n)
{
    if (n == 1)
        Console.Write(n + " ");
    if (n > 1)
    {    
        rec(n - 1);
        Console.Write(n + " ");
    }
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
rec(n);