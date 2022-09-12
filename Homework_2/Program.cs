/*
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
 
Console.WriteLine("Write a three-digit number: ");
int n = int.Parse(Console.ReadLine());

int n2digit  = n / 10;

Console.WriteLine(n2digit %10);

/*
// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100,999);
Console.WriteLine(a);

int a1digit  = a / 100;
int a3digit = a %10;
Console.WriteLine(a1digit %10);
Console.WriteLine(a3digit);

Console.WriteLine($"{a1digit}{a3digit}");
*/

/*
// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

if (n < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
    while (n > 999)
    n=n/10;
    Console.WriteLine(n%10);
    }  
*/

/*
// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a day number: ");
int a = int.Parse(Console.ReadLine());

if (a > 7 || a<1) 
    {
    Console.WriteLine("Choose number from 1 to 7");
    }
else
    {
    if (a >= 1 && a <= 5)
        {
        Console.WriteLine("Working day");
        }
    if (a >= 6 )
        {
        Console.WriteLine("Day off");
        }
    }
*/
