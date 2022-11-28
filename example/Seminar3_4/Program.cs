Console.Clear();

Console.Write("x1 ");
double q = Convert.ToDouble(Console.ReadLine());
Console.Write("y1");
double w = Convert.ToDouble(Console.ReadLine());
Console.Write("x2 ");
double e = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 ");
double r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(q-e, 2)+ Math.Pow(w-r, 2)));

//Math.Pow дать вывод в квадрат
//Math.Sqrt дать ввывод корень
// void процедура
// 
//Math.Sqrt(((q-w)^2)+((e-r)^2));

