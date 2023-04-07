Console.Write("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
number = -number;
if (number>=100&&number<=999)
Console.WriteLine(number%10);
else
Console.WriteLine("вы ввели не трехзначное число");
