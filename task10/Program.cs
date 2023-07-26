// See https://aka.ms/new-console-template for more information
int number = new Random().Next(100,1000);
int secondNum=(number/10)%10;
Console.WriteLine($"Вторая цифра числа {number} это {secondNum}");
