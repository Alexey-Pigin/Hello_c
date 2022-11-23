// Работа с массивами
Console.Clear();



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

// int max = Max(                              // 3 METOD
//     Max(a,b,c),
//     Max(d,e,f),
//     Max(g,h,i));
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result=arg2;
//     if(arg3>result) result=arg3;
//     return result;
// }
// Console.Write("TOP ");
// Console.WriteLine("max = "+max);

//  if array do 0  1  2  3  4  5  6  7  8 "index"
int [] array = {91,82,73,94,55,46,37,98,19};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}

int max = Max(                              // 4 METOD
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));
Console.Write("TOP ");
Console.WriteLine("max = "+max);

