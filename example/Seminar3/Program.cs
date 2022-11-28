Console.Clear();
Console.Write("1 number : ");
int n = Convert.ToInt32(Console.ReadLine());
int maxFirst = n, maxSeconn = -1;
while (n !=0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n> maxFirst)
    {
        maxSeconn = maxFirst;
        maxFirst = n;
    }
    else if(n>maxSeconn)
    maxSeconn = n;
}
Console.WriteLine(maxSeconn);