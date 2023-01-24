// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPal(string str)
{
    int n = str.Lenght;
    for (int i = 0; i < 2; i++)
    {
        if (str[i] != str[n-i])
        {
            Console.WriteLine("Не палиндром");
        }
        
    }   
}
 

int GetNum(string text)
{
    Console.WriteLine(text);
    string str = Console.ReadLine();
    // char[] arr = str.ToCharArray();
    // return arr;
    return str
    // Console.WriteLine($"This is 2nd el of array {arr[1]}?");
}

int arr = GetNum("Введите 5-тизначное число");
CheckPal(arr);