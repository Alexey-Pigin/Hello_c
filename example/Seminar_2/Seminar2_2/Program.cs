// Console.Clear();
// int n = new Random().Next(100,1000); // [100,99]
// Console.WriteLine($"Случ число {n}");  // вывести на экран это случ число   //("Случ число"+ n) оно равно по написанию
// // int n1 = n/100;
// // int n3 = n%10;
// // Console.WriteLine(n1*10+n3);
// int first = n / 100;
// int last = n % 10;
// Console.WriteLine($"первое и последнее {first }{ last}");

Console.Clear();
 System.Console.Write("1 number : ");
 int number1 = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("2 number : ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 if(number1 % number2 == 0)  // деление на первого на второй   % остаток при делении.
    Console.Write("yes");
else
    Console.Write($"no {number1 % number2}");