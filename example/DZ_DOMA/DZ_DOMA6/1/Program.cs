
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void arrayRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
        }
}

void array(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];
arrayRandom(numbers);

Console.WriteLine("Вот наш массив: ");
array(numbers);

int min = 0;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > 0)
        {
            min ++;
        }
}

    Console.WriteLine($"всего {numbers.Length} чисел, чисел больше '0' = {min}");

