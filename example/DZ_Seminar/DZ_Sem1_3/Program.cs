Console.Clear();
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int ton = num * (-1);
while(ton <= (-1))
{
    Console.Write($"{ton}");
    ton = ton + 1; //
} 