





/*

void ImageArray(int[,] image)
{
    for (int q =0;q<image.GetLength(0);q++)
    {
        for(int w=0;w<image.GetLength(1);w++)
        {
            //Console.Write($"{image[q,w]} ");
            if(image[q,w] == 0)
            {
                Console.Write($" ");
            }
            else
            Console.Write($"+");
        }
        Console.WriteLine();
    }
}
int [,] pic = new int [,];
ImageArray(pic);



5! = 5*4*3*2*1
     5*4!
        4*3!
            3*2!

double fac (int n)
{
    if(n==1) return 1;
    else return n*fac(n-1);
}
for(int i =1;i<40;i++)
{
    System.Console.WriteLine($"{i}! = {fac(i)}");
}
*/
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1)+(n-2)

double fib(int n)
{
    if (n==1 || n==2) return 1;
    else return fib(n-1) + fib(n-2);
}
for(int i =1;i<40;i++)
{
    System.Console.WriteLine($"{i}! = {fib(i)}");
}