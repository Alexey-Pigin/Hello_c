


// task 31

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 123);
}


string ReleaseArray(int[] array, int k)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == k)
            return "yes";
    }
    return "no";
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");


Console.Write("Введите число, которое Вы хотите найти в массиве: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое Вы хотите найти в массиве: ");
int l = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(ReleaseArray(array, k));
