Console.Clear();
Console.Write("Введите число - "); 
int Number1 = Convert.ToInt32(Console.ReadLine()); 
if (Number1 ==6 || Number1 == 7)
{
    Console.WriteLine($"yes {Number1}");
}
else
{
    Console.WriteLine($"no {Number1}");
}