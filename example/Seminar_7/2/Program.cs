

Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int row = int.Parse(numbers[0]);
int col = int.Parse(numbers[1]);
int[,] matrix = new int[row, col];