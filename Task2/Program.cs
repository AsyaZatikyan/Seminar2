/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
String anyNumberStr = Console.ReadLine();
int anyNumber = Convert.ToInt32(anyNumberStr);


if (anyNumberStr.Length > 2) 
{
    Console.WriteLine ("третья цифра:" + anyNumberStr[2]); 
}
else {
    Console.WriteLine ("третья цифры нет");
}






