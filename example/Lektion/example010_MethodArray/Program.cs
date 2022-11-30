// Работа с массивами 2
Console.Clear();

int [] array = {2,3,4,5,56,7,8,9,56,7,8};

int n = array.Length;
int find =56;

int index = 0;
while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine("index array "+index);
        break;
    }
    index++;
}