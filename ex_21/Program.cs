// Задача 21

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53int
double distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double sum_square = Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2); 
    double distance = Math.Pow(sum_square, 0.5);
    return distance;
    // Console.WriteLine(distance);
}

int GetKoordinate(string text)
{
    Console.WriteLine(text);
    int point = Int32.Parse(Console.ReadLine());
    return point;
}

int ax = GetKoordinate("для x точки A");
int ay = GetKoordinate("для y точки A");
int az = GetKoordinate("для z точки A");
int bx = GetKoordinate("для x точки B");
int by = GetKoordinate("для y точки B");
int bz = GetKoordinate("для z точки B");

double s = distance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками в 3d пространстве {s}"); 

// int distance() = Math.Pow((ax - bx), 2)


