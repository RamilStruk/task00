/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

/* Array.Sort(arr); */

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
   int[,] matrix = new int[rows, columns];
   Random rnd = new Random();

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(min, max + 1);
      }
   }
   return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j],5} ");
      }
      Console.WriteLine();
   }
}

int[] MatrixInArray(int[,] mtr)  
{
    int[] arr = new int[mtr.Length];
    int x = 0;
    for (int i = 0; i < mtr.GetLength(0); i++)
   {
      for (int j = 0; j < mtr.GetLength(1); j++)
      {
            arr[x] = mtr[i,j];
            x++;
      }
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

void DictionaryCounter(int[] arr)
{
    int number = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            Console.WriteLine($" число {number} встречается {count} раз");
            count = 1;
            number = arr[i];
        }
    }
    Console.WriteLine($" число {number} встречается {count} раз");
}

int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = MatrixInArray(matrix);
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
DictionaryCounter(array);