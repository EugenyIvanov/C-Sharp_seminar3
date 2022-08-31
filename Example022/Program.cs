Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int n = 1;
while(n <= x)
{
    Console.Write(Math.Pow(n, 2) + " ");
    n++;
}
while(x <= n)
{
    Console.Write(Math.Pow(n, 2) + " ");
    n--;
}