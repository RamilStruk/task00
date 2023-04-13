// выводит слочайное число из отрезка [10 99] и
// показывает наибольшую цифру числа


int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10-99 -> {number}");
/* int firstDigit =number / 10;
int secondDigit = number % 10; */


/* if (firstDigit > secondDigit)
{
    Console.WriteLine($"наибольшая цифра числа -> {firstDigit}");
}
    else
    {
     Console.WriteLine($"наибольшая цифра числа -> {secondDigit}");
    } */

//int maxDigit =firstDigit>secondDigit?firstDigit:secondDigit;
//    Console.WriteLine($"наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit (number);
Console.WriteLine($"наибольшая цифра числа -> {maxDigit}");

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}