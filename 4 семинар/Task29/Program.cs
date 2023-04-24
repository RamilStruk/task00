/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]
 */

Console.WriteLine("Введите длину массива");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(lenghtArray);
PrintArray(arr);
Console.Write($"->  [ ");
PrintArray(arr);
Console.Write($"] ");

int[] CreateArray(int size)
{
    int[] array = new int [size];
    Random random = new Random(); 
    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
