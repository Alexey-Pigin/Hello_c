// task 52

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[, ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summa = 0;
        double summa1 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write($"{matrix[j, i]} \t");
        }
        Console.WriteLine(matrix[0, j]);
        Console.WriteLine(matrix[matrix.GetLength(1)-1, j]);
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);