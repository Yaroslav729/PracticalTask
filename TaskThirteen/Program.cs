// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
string str = Console.ReadLine()!;
char[] arr = new char[str.Length];

    if (arr.Length > 2)
    {
        for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = str[i];         
            }
       }     
            
 else
    {
        Console.WriteLine("Введите трёхзначное число");
    }

    Console.WriteLine(arr[2]);

