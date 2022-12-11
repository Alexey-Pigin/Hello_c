



int i =0;
while(i<=10)
{
    double var = new Random().NextDouble() * (10-1)+1;
    Console.WriteLine(Math.Round(var, 2));
    i++;
}
