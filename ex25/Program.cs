void Funk(int a,int b)
{
    int mtp = a;
    if (a==0)
    { Console.WriteLine("0");}
    else if (a==1)
    { Console.WriteLine("1");}
    else
    {
    for(int i = 0; i < b-1; i++ )
    {
        mtp = mtp * a;
    }
    Console.WriteLine(mtp);
}
}
Funk (3,4);