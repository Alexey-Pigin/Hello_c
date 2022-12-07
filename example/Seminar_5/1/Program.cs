



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length;i++)
        array[i] = new Random().Next(-9,10);
}
void ReleaseArray(int [] array)
{
    int sumpol=0, sumnegativ = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if(array[i]>0)
            sumpol+=array[i];
        else
            sumnegativ+=array[i]
    

    }
}
int n = int.Parse(Console.ReadLine());

