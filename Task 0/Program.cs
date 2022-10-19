/*Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
a = 5; b = 25 -> да 
a = 2; b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3; b = 9 -> да
*/

Console.WriteLine("Введите два числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("Является");
}
else 
{
    Console.WriteLine("Не является");
}