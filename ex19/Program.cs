Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
string s = a.ToString();
string result = s;
char[] ar = s.ToCharArray();
Array.Reverse(ar);
s = new String(ar);
a = Convert.ToInt32(s);
if(result == s)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}