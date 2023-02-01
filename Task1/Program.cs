/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
String number = Console.ReadLine();
int number1 = Convert.ToInt32(number);

Console.WriteLine (number1 / 10 % 10 );
