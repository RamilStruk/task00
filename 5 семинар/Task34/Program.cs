/* Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет 
 количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine(" Массив: ");
PrintArray(numbers);

int count = 0;
for (int num = 0; num < numbers.Length; num++)
    if (numbers[num] % 2 == 0)
        count++;

Console.Write($" четных чисел {count} ");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}