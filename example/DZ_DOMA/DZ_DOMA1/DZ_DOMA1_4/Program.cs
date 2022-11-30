// Задача №8

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите чило..."); 

int n = Convert.ToInt32(Console.ReadLine()); // 
for (int i=2; i <= n; i = i + 2)
{
    if(i+2>n)
    Console.Write($"{i}");
    else
    Console.Write($"{i}, ");

}
    
// int number = Convert.ToInt32(Console.ReadLine());          // решение 1 
// int start = 1; 
// while (start <= number)
// {
//     if (start % 2 == 0)
//     {
//         Console.WriteLine(start + "    ");
//     }
//     start+=1;
// }