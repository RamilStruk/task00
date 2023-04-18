Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumbersMultiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");

int NumbersMultiplication(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            res *= i; // res = res * i;
        }
    }
    return res;
}