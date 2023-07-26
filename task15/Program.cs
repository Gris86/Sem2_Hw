// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите, пожалуйста, число: ");
int num= int.Parse(Console.ReadLine()!);
if(num==6 || num==7) Console.WriteLine("Да. Это выходной. 😊😊😊");
if(num>=1 && num<=5) Console.WriteLine("Нет. Это рабочий день. 😢😢😢");
else if(num<1 || num>7) Console.WriteLine("Введите, пожалуйста, число от 1 до 7!");
