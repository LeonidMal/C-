/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNum = 0;

if (number1 > maxNum)
{
    maxNum = number1;
} 
if (number2 > maxNum)
{
    maxNum = number2;
}
if (number3 > maxNum)
{
    maxNum = number3;
}

Console.WriteLine("max = " + maxNum);