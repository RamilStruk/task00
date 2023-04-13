//выводит случайное трехзначное число и
// удаляет вторую цифру этого числа

int number = new Random().Next(100, 999);
Console.WriteLine($"случайное трехзначное число{number}");

int DeleteCenter (int num)
{
    int first = num / 100;
    int third = num % 10;
    int answer = first * 10 + third;
    return answer;
}
Console.WriteLine($"двузначное число{DeleteCenter(number)}");
