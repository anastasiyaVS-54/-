// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

System.Console.WriteLine("Введите число 1:  ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2:  ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    System.Console.WriteLine("Кратны");
}
else
{
    System.Console.WriteLine("Не кратны");
}