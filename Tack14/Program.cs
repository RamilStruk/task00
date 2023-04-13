//проверяет, делится ли число одновременно на 7 и 23





Console.Writeline("введите число ");
int number = Convert.ToInt32(Console.Readline());
bool result = MultipleTwoDigits(number);
Console.WriteLine(result ? "да" : "нет");
bool MultipleTwoDigits(int num);
{
    return num % 7 == 0 && num % 23 == 0;

}