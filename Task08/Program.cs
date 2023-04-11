//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("введите число:");
int number = Convert.ToInt32(Console.ReadLine());


int number2 = 2;

if (number > 1)
{
    while (number2 <= number)
    {
        Console.Write(number2 + " ");
        number2 = number2 + 2;
    }
}