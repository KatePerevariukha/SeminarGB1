Console.Write("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int m = Convert.ToInt32(Console.ReadLine());
int max = n;
if (n > m) max = n;
if (m > n) max = m;
Console.Write("max=");
Console.Write(max);