/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


int day = 0;
bool needToCastToInt = true;
Console.WriteLine("Введите число дня недели от 1 до 7");
while (needToCastToInt)
{
    
    string dayFromConsole = Console.ReadLine();
    if (int.TryParse(dayFromConsole, out int dayDigit))
    {
        if (dayDigit > 0 && dayDigit < 8)
        {
            needToCastToInt = false;
            day = dayDigit;
        }
        else Console.WriteLine ("Ошибка! Введите число от 1 до 7");
    }
    else Console.WriteLine ("Ошибка! Введите число.");
}

if (day == 6 || day == 7) Console.WriteLine ($"{day} -> выходной");
else Console.WriteLine ($"{day} -> нет");