// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = number.ToString().Length;

if(length == 3)
{
int result = number / 10;
int result2 = result % 10;
System.Console.WriteLine(result2);
}
else
{
    System.Console.WriteLine("Вы ввели не верное число");
}