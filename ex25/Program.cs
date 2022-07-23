void Funk(int a,int b)
{
    int mtp = a;
    for(int i = 0; i < b-1; i++ )
    {
        mtp = mtp * a;
    }
    Console.WriteLine(mtp);
}
Funk (5,10);