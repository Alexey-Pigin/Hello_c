




Console.Clear();


Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine());

int max = a;

for( int i = 1; i < b; i++)
{
    max*=a;
}
Console.WriteLine($"число A в натуральную степень B   {max}");