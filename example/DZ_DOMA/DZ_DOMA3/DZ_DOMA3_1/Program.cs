


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите число - ");
        string Number = Console.ReadLine();
        int len = Number.Length;

if(len == 5)
{
            if (Number[0] == Number[4] && Number[1] == Number[3])
            {
                Console.WriteLine($"{Number}  является Палиндромом");
            }
            else
            {
                Console.WriteLine($"{Number}  Не является Палиндромом");
            }
        }

else

        {
            Console.WriteLine($"{Number}  Не является Палиндромом");
        }
    }
}