/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

Console.WriteLine("введите координаты точки");
Console.Write("X: ");
int XCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int YCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(XCoordinate, YCoordinate);
string result = quarter > 0 ? $"указанные координаты соответствуют четверти -> {quarter}" : "введены неккоректные координаты";
Console.WriteLine(result);


int Quarter(int X, int Y)
{
    if (X > 0 && Y > 0) return 1;
    if (X < 0 && Y > 0) return 2;
    if (X < 0 && Y < 0) return 3;
    if (X > 0 && Y > 0) return 4;
    return 0;
}

/* 

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
} */