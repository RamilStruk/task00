//принимает два числа, и выводит, является 
//ли первое число кратно второму.
//если нет - выводится остаток деления

Console.WriteLine("введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Remainder (numberA ,numberB);

if (result == 0)
{
    Console.Write("кратно");
}
else
{
    Console.Write($"не кратно, остаток {result}");
}

int Remainder(int numA, int numB)
{
    return numA % numB;
}