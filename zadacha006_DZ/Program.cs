/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


// начало проверки "на дурака"

bool needToCastToInt = true;
int number = 0;

while (needToCastToInt)
{
    Console.WriteLine("Введите число: ");
    string numberFromConsole = Console.ReadLine();
    if (int.TryParse(numberFromConsole, out int newNumber))
    {
        needToCastToInt = false;
        number = newNumber;
    }
    else
    {
        Console.WriteLine("Ошибка! Введите число.");
    }
}

// конец проверки "на дурака"


Console.WriteLine($"Вы ввели число: {number}");
string str = number.ToString();
int lenght = str.Length;

if (lenght < 3) Console.WriteLine($"{str} -> Третьей цифры нет");
else Console.WriteLine($"{str} -> {str[2]}");

