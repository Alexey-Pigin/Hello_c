



string [,] table= new string[2,5];
// string.Empty
//   table [0,0] table [0,1] table [0,2] ..
//   table [1,0] table [1,1] table [1,2] ..
table [1,2] = "new string";
for (int i =0; i<2; i++)
{
    for ( int u = 0; u<5; u++)
    {
        System.Console.WriteLine($"{table[i,u]}-");
    }
}





void PrintArray(int[,] matr)
{
    for (int q =0;q<matr.GetLength(0);q++)
    {
        for(int w=0;w<matr.GetLength(1);w++)
        {
            System.Console.Write($"{matr[q,w]} ");
        }
        System.Console.WriteLine();
    }
}
void ArrayR(int[,] matr)
{
    for (int q =0;q<matr.GetLength(0);q++)
    {
        for(int w=0;w<matr.GetLength(1);w++)
        {
            matr[q,w] = new Random().Next(1,10);
        }
    }
}
int [,]matrix = new int[6,8];
PrintArray(matrix);
ArrayR(matrix);
System.Console.WriteLine("tables");
PrintArray(matrix);