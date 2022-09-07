/*
// 1. Напишите программу, которая на вход принимает два числа и выдаёт,
//    какое число большее, а какое меньшее.

string s_n_1 = Console.ReadLine();
string s_n_2 = Console.ReadLine();

int n_1 = int.Parse(s_n_1);
int n_2 = int.Parse(s_n_2);

if (n_1 > n_2)
{
    Console.Write($"The number {n_1} is greater than {n_2}");
}
else if (n_1 == n_2)
{
    Console.Write($"The number {n_1} is equal to the number {n_2}");
}
else
{
    Console.Write($"The number {n_2} is greater than {n_1}");
}
*/

/*
// 2. Напишите программу, которая принимает на вход
//    три числа и выдаёт максимальное из этих чисел.

int n_1 = int.Parse(Console.ReadLine());
int n_2 = int.Parse(Console.ReadLine());
int n_3 = int.Parse(Console.ReadLine());

if (n_1 < n_2)
{
    n_1 = n_2;
}
if (n_1 < n_3)
{
    n_1 = n_3;
}
Console.Write($"The number {n_1} is the largest!");
*/

/*
// 3. Напишите программу, которая на вход принимает число и выдаёт,
//    является ли число чётным (делится ли оно на два без остатка).

int n_1 = int.Parse(Console.ReadLine());

if (n_1 % 2 == 0)
{
    Console.Write($"The number {n_1} is even");
}
else
{
    Console.Write($"The number {n_1} is odd");
}
*/

/*
// 4. Напишите программу, которая на вход принимает число (N),
//    а на выходе показывает все чётные числа от 1 до N.

int n_1 = int.Parse(Console.ReadLine());
int i = 2;

while (i <= n_1)
{    
    Console.Write($"{i} ");
    i += 2;
}
*/
