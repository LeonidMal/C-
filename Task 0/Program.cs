/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int N = number % 10;

if (number < 99)
{
    Console.WriteLine("Это не трёхзначное число");
}
else if (number > 1000)
{
    Console.WriteLine("Это не трёхзначное число");
}
else
{
    Console.WriteLine(N);
}
    