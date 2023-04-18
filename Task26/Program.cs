/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int DigitCount (int num)
{
    int sum = 0;
    while (num != 0)
    {
        num = num / 10;
        sum++;
    }
        return sum;
}

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitCount = DigitCount(number);
Console.WriteLine($"{digitCount}");