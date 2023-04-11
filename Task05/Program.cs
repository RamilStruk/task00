//показывает все числа в промежутке от -N до N


Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = -number1;
while (count <= number1)
{
    Console.Write(count + " ");
    count++;
}