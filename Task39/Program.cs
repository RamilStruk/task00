/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */



//  0 1 2 3 4
// [1 2 3 4 5] -> [5 4 3 2 1]
//Array.Reverse(array);

void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(6, 1, 25);
PrintArray(array);

Console.WriteLine();
ReverseArray(array);
PrintArray(array);

Console.WriteLine();
Array.Reverse(array);
PrintArray(array);