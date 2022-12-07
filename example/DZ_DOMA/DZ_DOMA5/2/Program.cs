





/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int sum = 0;
for (int z = 0; z < numbers.Length; z+=2)
    sum+= numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

