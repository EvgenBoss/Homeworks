
Console.Write("День недели ");
String a = Console.ReadLine();
int length = a.Length;
if(length < 2)
{
    if (a.Equals("1")||a.Equals("2")||a.Equals("3")||a.Equals("4")||a.Equals("5")||a.Equals("6")||a.Equals("7")){
    if (a.Equals("6")||a.Equals("7")) 
    {
        Console.WriteLine("День выходной"); 
    }
    else 
    {
        Console.WriteLine("День будний");
    }
}
else 
{
    Console.WriteLine("Введено что-то не то");
}
}
else
{   
    Console.WriteLine("В неделе всего 7 дней");
    return;
}

