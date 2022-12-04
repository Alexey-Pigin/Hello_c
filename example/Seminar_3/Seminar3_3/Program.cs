Console.Clear();
Console.Write("Введите чктверть   I,II,III,IV: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
    Console.WriteLine($"x > 0; y > 0");
else if (x  == 2)
    Console.WriteLine("x < 0: y > 0");
else if (x  == 3 )
    Console.WriteLine("x < 0: y < 0");
else if (x  == 4 )
    Console.WriteLine("x > 0; y < 0");

    