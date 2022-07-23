int[] Array = new int[8];
{
    for(int i = 0; i < Array.Length; i++)

        Array[i] = new Random().Next(1,10);
}
var str = string.Join(" ", Array);
Console.WriteLine(str);
