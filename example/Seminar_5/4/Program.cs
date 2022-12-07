


// task 31

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-110, 123);
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

int ReleaseArray2(int[] array, int k)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i]<99)
         count ++;
    }
    
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");

int count =0;
int res=10;

if (res <100)
{
    res+=1;
    count++;
}
Console.Write("начало: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" result {res}");



Console.WriteLine(ReleaseArray2(array, k));
