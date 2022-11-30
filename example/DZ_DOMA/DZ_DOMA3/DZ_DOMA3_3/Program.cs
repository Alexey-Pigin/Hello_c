Console.Clear();

Console.Write("   press number ");
double q = Convert.ToDouble(Console.ReadLine());
for (int i =1; i <= q; i++)
    Console.WriteLine($"{i * i* i}");