


/*
// 41 task
Console.Clear();

Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0)
        count++;
}
Console.WriteLine(count);

*/
// 41 task
Console.Clear();

string[] n = Console.ReadLine().Split(" ");
int count = 0;
foreach (string i in n)
{
    if (int.Parse(i) > 0)
        count++;
}
Console.WriteLine(count);

// 41 task
Console.Clear();

int[] array = {1, 2, 3, 4, 5};
int count = 0;
foreach (int i in array)
{
    if (i > 0)
        count++;
}
Console.WriteLine(count);