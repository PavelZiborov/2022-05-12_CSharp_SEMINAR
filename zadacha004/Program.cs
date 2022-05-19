/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if ((firstNumber * firstNumber == secondNumber) || (secondNumber * secondNumber == firstNumber)) // значок || - ИЛИ
{
    Console.WriteLine("Да, Одно из чисел кратно другому");
}
else
{
    Console.WriteLine("Нет, Одно из чисел НЕ кратно другому");
}