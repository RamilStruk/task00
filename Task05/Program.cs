Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = -number1;
while (count <= number1) 
{
    Console.WriteLine(count + " ");
    count++;
}