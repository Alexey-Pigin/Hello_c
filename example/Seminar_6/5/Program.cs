









Console.Write("A: ");
int n = int.Parse(Console.ReadLine());
string res = string.Empty;
while(n>0)
{
    res = Convert.ToString(n%2) + res;
    n/=2;
}
Console.Write(res);