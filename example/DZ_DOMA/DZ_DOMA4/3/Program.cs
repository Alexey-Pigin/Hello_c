

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
*/

int [] numbers = new int[8];

Console.WriteLine("минимальное число массива");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("максимальное число массива");
int b = int.Parse(Console.ReadLine());


for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(a, b);
    Console.Write($" {string.Join(",  >   " ,numbers[i])}");
 }
 Console.WriteLine($"  [{string.Join(", ", numbers)}]");    // не понял этот механизм


