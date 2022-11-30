
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//    Решение для угара)

// Console.Clear();
// Console.Write("число трехзначное - "); 
// int Number = Convert.ToInt32(Console.ReadLine()); 
// int num1 = Number / 100;
// int num2 = Number % 10;
// Console.WriteLine($"вторая цифра числа  {(Number-(num1*100+num2))/10}");

Console.Clear();
int n = new Random().Next(100,1000); // [100,999]
Console.WriteLine($"Случ число {n}");  // вывести на экран это случ число   //("Случ число"+ n) оно равно по написанию
int n2 = n / 10;
int n3 = n2 % 10;
Console.WriteLine($"ВТОРОЕ ЧИСЛО {n3}");
