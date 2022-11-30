// Работа с массивами 3
Console.Clear();

void FullArray(int [] collection)            //  code random array    создали массив
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)                   //  code index создали массив из чисел рандома
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine("number = "+col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;     //  это показывает что наше число выходит за пределы массива 

    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;
}
int [] array = new int[10];

FullArray(array);  // принудительно 
array[2] = 7;      // принудительно добавили в наш путь массива числа 7 на 2 и 7 позицию номера.
array[7] = 7;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 70);
Console.WriteLine("position = "+pos);

// int n = array.Length;
// int find =56;

// int index = 0;
// while(index<n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine("index array "+index);
//         break;
//     }
//     index++;
// }