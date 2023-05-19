/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

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
bool ValueMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else
        return false;
}

void ChangePosition(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

// 1 7 6   1 2 6
// 2 3 4   7 3 4
// 4 5 6   4 5 6 


int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (ValueMatrix(matrix))
{
    ChangePosition(matrix);
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Error!");
}