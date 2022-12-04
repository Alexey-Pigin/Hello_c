




// Console.Clear();

// Console.Write("Введите кол-во эл-ов в массиве ");

// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// for(int i=0; i<array.Length;i++);
// {
//     Console.Write("Введите кол-во эл-ов в массиве ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     array[i] = x;
// }
// Console.WriteLine($"");

// double q = Convert.ToDouble(Console.ReadLine());
// for (int i =1; i <= q; i++)
//     Console.WriteLine($"{i * i}");

//Math.Pow дать вывод в квадрат
//Math.Sqrt дать ввывод корень
// void процедура
// 
//Math.Sqrt(((q-w)^2)+((e-r)^2));
   //     список работает дольше чем массив
   //     





//    найти мак
Console.Clear();

int maxN(int n, int m)
{
    if(n>m)
        return n;
    return m;
}
Console.Write("Введите кол-во эл-ов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во эл-ов в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"RESULT:    {maxN(n,m)}");

