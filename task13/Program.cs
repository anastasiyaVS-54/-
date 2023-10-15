// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// решение 1


// System.Console.WriteLine("Введите число:  ");
// string userNumber = Console.ReadLine();


// int lengthfString = userNumber.Length;

// Console.WriteLine($"Длина строки: {lengthfString}");

// if(lengthfString >= 3)
// {
//     System.Console.WriteLine(userNumber[2]);
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }


//  решение 2

Console.Write("Введите число:  ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int length = userNumber.ToString().Length;  

if (length >= 3)
{
    int result = (userNumber / (int)Math.Pow(10, length - 3)) % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}