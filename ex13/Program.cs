Console.Write("Введите число ");
String a = Console.ReadLine();
int length = a.Length;
if(length < 3)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    Console.WriteLine(a[2]);   
}