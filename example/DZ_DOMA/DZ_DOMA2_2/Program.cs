// Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();


// if (n > 99)
// {
//     string n1 = "";
//     n1 = Convert.ToString(n);
//     Console.WriteLine(n1[2]);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет!");
// }


// Console.Write("Первое число - "); 
// int n = Convert.ToInt32(Console.ReadLine()); 

int n = new Random().Next(100,100000); // [100,99999]
Console.WriteLine($"Случ число {n}");

if (n>99)
{
    if (n>9999)
    {
        int first = n / 100;
        int last = first % 10;
        Console.WriteLine($"ответ {last}");
        return;
    }
    if (n>999)
    {
        int first1 = n / 10;
        int last1 = first1 % 10;
        Console.WriteLine($"ответ {last1}");
        return;
    }
    if (n>99)
    {
        int first2 = n;
        int last2 = first2 % 10;
        Console.WriteLine($"ответ {last2}");
        return;
        

    }
    
    
    
}
else
{
    Console.WriteLine("третьей цифры нету");
}

// int last3 = n % 10;
// Console.WriteLine(last3);
// if (n>9999)
    // Console.WriteLine("третьей цифры нет!");


//int first = n / 100;