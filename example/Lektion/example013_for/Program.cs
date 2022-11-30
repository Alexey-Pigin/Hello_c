


// string s = "qwerty"
//             012345
//            s[0]
string text = "jg hg gg hh ghg";

//           Замена пробелов черточками
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for(int i=0;i<lenght;i++)
//     {
//         if(text[i] == oldValue) result = result +$"{newValue}";
//         else result = result+ $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace (text, ' ','|');
// Console.WriteLine(newText);


//   Замена симвова и знака в тексте на обозначенный

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for(int i=0;i<lenght;i++)
    {
        if(text[i] == oldValue) result = result +$"{newValue}";
        else result = result+ $"{text[i]}";
        
    }

    return result;
}
string newText = Replace (text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'h','R');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'g','A');
Console.WriteLine(newText);




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
        for(int ad = i + 1; ad < array.Length; ad++)
        {
            if(array[ad]<array[minPosition])
            {
                minPosition=ad;
                
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

