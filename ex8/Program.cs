int a;
int b;                          
Console.Write("введите число: ");
a = Console.Read();
b = a - 48;
if (a % 2==1)
{
    Console.WriteLine("число нечетное");
    b = b + 1;
    for (int i = 1; i < b; i++)
    {
       if(i % 2==0) Console.WriteLine(i);
    }
}
 else
{
    Console.WriteLine("Число четное");
    for (int i = 1; i < b + 1 ; i++)
    {
       if(i % 2==0) Console.WriteLine(i);
    }
} 






