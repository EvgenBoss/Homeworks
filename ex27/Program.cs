Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int summ = 0;
for(int i = 10; x > i/10; i = i * 10)
{
        summ = summ + (x * 10) / i % 10;
}
Console.WriteLine(summ);
