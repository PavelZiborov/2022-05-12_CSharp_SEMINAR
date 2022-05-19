/*
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());



/* можно так

if ((number%7 == 0) && (number%23 == 0)) 
    Console.WriteLine("делится одновременно на 7 и 23");
else
    Console.WriteLine("не делится одновременно на 7 и 23");

или так: */

string resultText = ((number % 7 == 0) && (number % 23 == 0)) // значок && - И. В скобочках условие
    ? $"{number} кратно 7 и 23"                               // значок ? тоже самое что и действие после if
    : $"{number} не кратно 7 и 23";                           // значок : тоже самое что и действие после else
Console.WriteLine(resultText);

