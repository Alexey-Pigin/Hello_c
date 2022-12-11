


Console.Write("number: ");
int n = int.Parse(Console.ReadLine());
int x, a0=0,a1=1;
for (int i =0; i < n; i++)
{
    Console.Write($"{a0}   ");
    x=a0+a1;
    a1=x;
    a0=a1;
}


Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];
for (int i = 0; i < a.Length; i++)
    b[i] = a[i];
b[0] = 5;
Console.WriteLine(string.Join(", ", a));
Console.WriteLine(string.Join(", ", b));