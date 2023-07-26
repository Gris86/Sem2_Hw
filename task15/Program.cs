// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите, пожалуйста, число: ");
int day= int.Parse(Console.ReadLine()!);
/*if(num==6 || num==7) Console.WriteLine("Да. Это выходной. 😊😊😊");
if(num>=1 && num<=5) Console.WriteLine("Нет. Это рабочий день. 😢😢😢");
else if(num<1 || num>7) Console.WriteLine("Введите, пожалуйста, число от 1 до 7!"); */

switch (day) 
{
  case 1:
    Console.WriteLine("Нет");
    break;
  case 2:
    Console.WriteLine("Нет");
    break;
  case 3:
    Console.WriteLine("Нет");
    break;
  case 4:
    Console.WriteLine("Нет");
    break;
  case 5:
    Console.WriteLine("Нет");
    break;
  case 6:
    Console.WriteLine("Да");
    break;
  case 7:
    Console.WriteLine("Да");
    break;
  default:
    Console.WriteLine("Введите, пожалуйста, число от 1 до 7!");
     break;

}