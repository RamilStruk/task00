//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

int max = 0;

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine("max = " + max);