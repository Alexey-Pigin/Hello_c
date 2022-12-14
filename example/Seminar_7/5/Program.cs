


// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=116&id_problem=719


using System;
  
public class Sum{
  private static void Main(){
        string[] numbers = Console.ReadLine().Split(" ");
        double x1 = int.Parse(numbers[0]);
        double y1 = int.Parse(numbers[1]);
        double x2 = int.Parse(numbers[2]);
        double y2 = int.Parse(numbers[3]);
        double x3 = int.Parse(numbers[4]);
        double y3 = int.Parse(numbers[5]);
        double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        double C = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
        double p = (A + B + C) / 2;
        Console.WriteLine(Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C))));
    }
}