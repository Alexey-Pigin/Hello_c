// Задача №4

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Clear();
Console.Write("Первое число - "); 
int Number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Второе число - "); 
int Number2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Третье число - "); 
int Number3 = Convert.ToInt32(Console.ReadLine()); 
int max = Number1;

// if(Number1>Number2 && Number1>Number3)
//     Console.Write(Number1);
// else if(Number2>=Number1&&Number2>=Number3)
// if (Number2 > max)
// {
//     max = Number2; 
// }
// if (Number3 > max)
// {
//     max = Number3;
// }
if (Number2 > max)
    max = Number2; 
if (Number3 > max)
    max = Number3;

    // int i =0;
    // int max = -10000;
    // while(i<3)
    // {
    //     int n = Convert.Write("введите число");
    //     if (max<n)
    //     max=n;
    //     i++;
    // }
Console.WriteLine("наибольшее " + max);