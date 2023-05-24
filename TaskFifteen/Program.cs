Console.Clear();
Console.Write("Напишите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <= 5)
Console.Write("Нет");
 else if (num == 6 || num == 7)
Console.Write("Да");
else 
Console.Write("Введите корректные данные");