Console.Clear(); // для последней цифры числа, останок при делении на 10
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num % 10);