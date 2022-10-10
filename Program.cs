// Задача 11 Напишите программу, которая выводит случайное трёхзначное число и удаляет
//вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

/*int number = new Random().Next(100, 1000);
Console.WriteLine("Random number = " + number);
int digit1 = number / 100;
int digit2 = number % 10;

int res = digit1 * 10 + digit2;
Console.WriteLine($"Result = {res}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*Console.WriteLine("Enter a num: ");
int num = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2;

if (num < 0)
    num = -num;
if (num > 100)
{
    int digit = num.ToString()[digitIndex] - '0';
    Console.WriteLine("The third digit " + digit);
}
else
    Console.WriteLine($"In the entered number {num} there is no third digit");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number of the day of the week: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i >= 1 & i <= 5) Console.WriteLine("Weekday");
if (i == 6 | i == 7) Console.WriteLine("Weekend");
if (i > 7 | i < 1) Console.WriteLine("There is no such day");
