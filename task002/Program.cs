// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void GetThirdDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("В вашем числе нет третьей цифры");
    }
    else
    {
        while (num > 999)
        {
            num /=10; // Делим число на 10, пока оно больше 999
        }
        num = num % 10;        
        Console.WriteLine("Третья цифра вашего числа: " + num);
    }
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
GetThirdDigit(number);

