// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void Holiday(int num)
{
    if (num < 1 || num > 7)
    {
        Console. WriteLine("Введённая цифра не соответствует дню недели");
    }
        else        
            if (num == 6 || num == 7)
        {
            Console.WriteLine("Этот день - выходной. Ура");
        }            
    else
    {
        Console.WriteLine("Этот день - рабочий");
    }
}

Console.WriteLine("Вветите номер дня недели (от 1 до 7): ");
int number = int.Parse(Console.ReadLine()!);
Holiday(number);
