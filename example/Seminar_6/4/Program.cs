





Console.Write("A: ");
int n = int.Parse(Console.ReadLine());
Console.Write("B: ");
int m = int.Parse(Console.ReadLine());
Console.Write("C: ");
int b = int.Parse(Console.ReadLine());

if (n < m+b && m<n+b && b < n+m)
Console.Write("YES: ");
else
Console.Write("NO ");