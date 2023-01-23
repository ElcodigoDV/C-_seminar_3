// Задача 23

// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double ToCube (int num)
{
    for (int i = 1, i < num+1; i++;)
    {
        double cube = Math.Pow(i, 3);
        Console.Write(cube + ", ");
    }
}

int GetNumber(string text)
{
    Console.WriteLine("Insert some number");
    string text = Console.ReadLine();
    int num = Int32.Parse(text);
    return num;
}

GetNumber (text);
ToCube (num);
