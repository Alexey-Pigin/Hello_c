




int[] array = {1,8,6,3,4,1,6,8,3,9,6};


void printArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write( $"{array[i]}  ");
    }
    Console.WriteLine();
}

printArray(array);

void selectionSort(int[] array)
{
    for(int i = 0; i <array.Length -1;i++)
    {
        int minPosition = i;
        for(int g = i + 1; g < array.Length; g++)
        {
            if(array[g]>array[minPosition])
            {
                minPosition=g;

            }
        }
        //
        //
        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}
printArray(array);
selectionSort(array);

printArray(array);
