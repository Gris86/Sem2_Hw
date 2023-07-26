// See https://aka.ms/new-console-template for more information
int num=new Random().Next(0,100000);
if(num < 99) Console.WriteLine("В данном числе нет третьей цифры.");
else {
    int num2=num;
    while (num>1000)
        num=num/10;
Console.WriteLine($"Третья цифра числа {num2} это {num%10}");     
}
