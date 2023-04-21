/* задайте массив из 12 элементов.
заполните его случайными числами в диапазоне {-9:9}
найдите сумму положительных и отрицательных чисел массива */


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int SumPositiveElements (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int SumNegativeElements (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int sumPositiveElem = SumPositiveElements(array);
int sumNegativeElem = SumNegativeElements(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");