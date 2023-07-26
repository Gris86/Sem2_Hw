// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
if(number.Length!=3 && number[0]!=0) Console.WriteLine("Данное число не трехзначное");
else Console.WriteLine($"Второе число числа {number} это {number[1]}");
