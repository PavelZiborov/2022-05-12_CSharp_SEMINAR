/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

while(true)
{
    Console.WriteLine("Введите трехзначное число:");
    string numberFromConsole = Console.ReadLine();
    int number = int.Parse(numberFromConsole);

    if (number >= 100 && number <= 999)
    {
        string srr = number.ToString();
        Console.WriteLine($"{srr[1]}");
        break;
    }
    else Console.WriteLine("Ошибка. Введите трехзначное число");
}