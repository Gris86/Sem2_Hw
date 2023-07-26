// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string num=Console.ReadLine();
if(num.Length<3) Console.WriteLine("В данном числе нет третьей цифры.");
else Console.WriteLine($"Третья цифра числа {num} это {num[2]}");