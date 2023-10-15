// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// решение через получения
System.Console.WriteLine("Введите число:  ");
string userNumber = Console.ReadLine();


int lengthfString = userNumber.Length;

Console.WriteLine($"Длина строки: {lengthfString}");

if(lengthfString >= 3)
{
    System.Console.WriteLine(userNumber[2]);
}
else
{
    System.Console.WriteLine("NO");
}
