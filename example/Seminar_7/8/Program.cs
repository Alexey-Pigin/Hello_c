




// task 46


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if ( i%2 == 0)
        {
            i*=i;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ( j%2 == 0)
        {
            j*=j;
        }
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];

InputMatrix(matrix);