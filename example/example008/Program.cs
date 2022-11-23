// Работа с функциями и решение больших неравенств

Console.Clear();


int a = 100;
int b = 8;
int c = 6;
int d = 80;
int e = 4000;
int f = 5;
int g = 999;
int h = 10;
int i = 21;


// if (b > max) max = a;                       1 METOD
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// if (f > max) max = f;
// if (g > max) max = g;
// if (h > max) max = h;
// if (i > max) max = i;

// int max1 = Max(a,b,c);                      2 METOD
// int max2 = Max(d,e,f);
// int max3 = Max(g,h,i);
// int max = Max(max1,max2,max3);

int max = Max(                              // 3 METOD
    Max(a,b,c),
    Max(d,e,f),
    Max(g,h,i));

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}




Console.Write("TOP ");
Console.WriteLine("max = "+max);