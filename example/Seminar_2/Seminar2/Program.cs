
Console.Clear();
int n = new Random().Next(10,100); // [10,99]
Console.WriteLine($"Случ число {n}");  // вывести на экран это случ число   //("Случ число"+ n) оно равно по написанию
int first = n/10;                                                   // колво десятков    78/10 =7
int last = n % 10;   // отстаток [10,99]  % 100  = [10,99].        // кол-во едениц
// if(n1>n2)
//     Console.Write(n1);
// else
//     Console.Write(n2);