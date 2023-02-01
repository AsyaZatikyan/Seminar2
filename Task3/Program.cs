/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру,обозначающую день недели: ");
String DayNumberStr = Console.ReadLine();
int DayNumber = Convert.ToInt32(DayNumberStr);

void CheckingNumberTheDayOfTheWeek (int DayNumber) {
if(DayNumber == 6 || DayNumber == 7) {
Console.WriteLine("да, выходной");
}
else if(DayNumber < 1 || DayNumber > 7) {
    Console.WriteLine("Указанное число не является днем недели");
}
else Console.WriteLine("нет не выходной");
} 
CheckingNumberTheDayOfTheWeek(DayNumber);
