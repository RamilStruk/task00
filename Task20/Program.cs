/* double d = Math.Sqrt(5);
double d1 = 5.09987654;
double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);
Console.WriteLine(d1Round);
double d = Math.Round(Math.Sqrt(5), 2);


Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21 */

double DistanceAB(int xa, int ya, int xb, int yb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);   
    return distAB;
}

Console.WriteLine("Введите координаты точки A  ");
Console.Write("Xa: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Ya: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B  ");
Console.Write("Xb: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Yb: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xACoordinate, yACoordinate, xBCoordinate, yBCoordinate);
double distRound = Math.Round (distanceAB, 2, MidpointRounding.ToZero);
Console.WriteLine(distRound);
