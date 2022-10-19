/*Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Например:
4 -> 16 
-3- -> 9 
-7 -> 49*/

Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int sqrNumber = number * number;

Console.WriteLine("Квадрат числа " + number + " равен " + sqrNumber);
