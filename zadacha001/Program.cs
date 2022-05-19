/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное число: {number}");
int firstDigit = number / 100;
int secondNumber = number % 10;

Console.WriteLine($"Первое число: {firstDigit}");
Console.WriteLine($"Второе число: {secondNumber}");

Console.WriteLine($"Итоговое число: {firstDigit}{secondNumber}");

/*
Или можно так как Серж Голиков:


*/

