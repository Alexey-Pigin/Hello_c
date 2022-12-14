





/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-10, 110)); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[i,j];
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.Write($"Среднее арифметическое строки { sum / matrix.GetLength(0)} ");
        Console.WriteLine();
    }
}
void ReleaseMatrix1(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum =0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum+=matrix[j,i];
            Console.Write($"{matrix[j, i]} \t");
        }
        Console.Write($"Среднее арифметическое столбиков { sum / matrix.GetLength(1)} ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Результат: ");

ReleaseMatrix(matrix);
Console.WriteLine();


Console.WriteLine("Результат столбиков: ");
ReleaseMatrix1(matrix);


