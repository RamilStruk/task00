// программа которая определяет, является ли первое число квадратом второго;
Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1) ;
{
    Console.WriteLine("первое число является квадратом второго");
};
else
{
    Console.WriteLine("первое число не является квадратом второго");
}
