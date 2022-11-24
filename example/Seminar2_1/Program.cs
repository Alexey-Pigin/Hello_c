Console.Clear();
int n = new Random().Next(100,1000); // [100,99]
Console.WriteLine($"Случ число {n}");  // вывести на экран это случ число   //("Случ число"+ n) оно равно по написанию
// int n1 = n/100;
// int n3 = n%10;
// Console.WriteLine(n1*10+n3);
int first = n / 100;
int last = n % 10;
Console.WriteLine($"первое и последнее {first }{ last}");