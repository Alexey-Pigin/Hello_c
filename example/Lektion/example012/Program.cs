Console.Clear();


void Method1()
{
    Console.WriteLine("Avtor///");
}
Method1();


void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Text  {ms");



void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("RRRRRRRRR",5);
Method21(msg:"RRRRRRRRR",count:5);



int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


string Method4(int count, string c)
{
    int i = 0;
    string result="   ";   //    String.Empty   пустая строка.
    while (i<count)
    {
        result = result + c;
        i++;

    }
    return result;
}
string res = Method4(10,"UYUYUYUYUYUYUYUUYU");
Console.WriteLine(res);


string Method5(int count, string c)
{
    string result="   ";   //    String.Empty   пустая строка.
    for (int i=0;i<count;i++)
    {
        result = result + c;
    }
    return result;
}
string ps = Method5(10,"------");
Console.WriteLine(ps);


// таблица умножения
for(int i = 2; i <= 10;i++)
{
    for (int j= 2; j <= 10;j++)
    {
        Console.WriteLine($"{i} x {j}  =  {i*j}");
    }
    Console.WriteLine();
}