





void rec(string s2, string c)
{
    string s1;
    int i;
    if (s2.Length == 0)
        Console.WriteLine(c);
    else
    {
        for (i = 0; i < s2.Length; i++)
        {
            c += s2[i];
            s1 = s2;
            s1 = s1.Remove(i, 1);
            rec(s1, c);
            c = c.Remove(c.Length - 1, 1);
        }
    }
}


Console.Clear();
string? s = Console.ReadLine(), c, s2;
for(int i = 0; i < s.Length; i++)
{
    c = s[i].ToString();
    s2 = s;
    s2 = s2.Remove(i, 1);
    //Console.WriteLine(s2);
    rec(s2, c);
}