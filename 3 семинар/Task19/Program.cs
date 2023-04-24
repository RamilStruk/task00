/* Напишите программу, которая принимает на вход пятизначное число и
проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num = 0, num1 = number;
while (number > 0)
{
    num = num * 10 + number % 10; number /= 10;
}
Console.WriteLine(num1 == num ? "палиндром" : "не палиндром");
