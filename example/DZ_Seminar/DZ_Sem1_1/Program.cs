// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Clear();
 System.Console.Write("Число для проверки на квадрат : ");
 int Number2 = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Число предполагаемое на квадрат : ");
 int number = Convert.ToInt32(Console.ReadLine());

 if(Number2 == number * number)
 {
 Console.WriteLine( "Yes");
 }
 else
 {
 Console.WriteLine( "No");
 }