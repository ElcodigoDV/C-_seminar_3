// Задача 23

// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ToCube (int num)
{   double cube = 0;
    for (int i = 1; i < num; i++)
    {
        cube = Math.Pow(i, 3);
        Console.Write(cube + ", ");
    }
    Console.Write(Math.Pow(num,3));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    // string text = Console.ReadLine();
    int num = Int32.Parse(Console.ReadLine());
    // Console.WriteLine(num);
    return num;
}

int number = GetNumber ("Ведите число: ");
ToCube (number);
