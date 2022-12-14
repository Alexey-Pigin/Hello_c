



/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такой позиции в массиве нет
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
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

Console.Write("Введите строку: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите столбец: ");
int m = int.Parse(Console.ReadLine());
if (n<0 | n>matrix.GetLength(0) | m<0 | m>matrix.GetLength(1))
Console.WriteLine("Элемент не существует  ");
else
Console.WriteLine("Значение элемента массива = {0}", matrix[n-1, m-1]);