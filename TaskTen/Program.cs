Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = 0;
if (a < 100 || a > 1000)
Console.Write("Вы ввели не трёхзначное число");
else

Console.Write($"{b = a / 10 % 10}");