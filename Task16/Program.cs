//принимает два числа и проверяет, является ли одно квадратом другого

Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool result = isSquare(number1, number2);
Console.WriteLine(result ? "да" : "нет");

bool isSquare(int num1, int num2)
{
    return (num1 == num2 + num2) || (num2 == num1 + num1);
}