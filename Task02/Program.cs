//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.


int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("числа равны");
}
else if (number1 > number2)
{
    max = number1;
    min = number2;
    Console.WriteLine("max = " + max + " и " + "min = " + min);
}

else
{
    max = number2;
    min = number1;
    Console.WriteLine("max = " + max + " и " + "min = " + min);
}

