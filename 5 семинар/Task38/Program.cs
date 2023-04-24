/* Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным 
 элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int num = 0; num < numbers.Length; num++)
{
    if (numbers[num] > max)
        {
            max = numbers[num];
        }
    if (numbers[num] < min)
        {
            min = numbers[num];
        }
}

Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
}