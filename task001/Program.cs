// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void GetSecondNum(int num)
{
    if (num < 100 || num >= 1000)
    {
        Console.WriteLine("Ваше число не подходит");
    }    
    else
    {
    num = num / 10 % 10;
    Console.WriteLine("Вторая цифра вашего числа: " + num);
    }
}

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
GetSecondNum(number);

