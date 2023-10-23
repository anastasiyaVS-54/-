// принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным,
//  в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.
Console.Clear();


System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string numberStr = number.ToString();
string reversedStr = "";

for (int i = numberStr.Length -1; i >= 0; i--)
{
    reversedStr += numberStr[i];
}


if (number >= 10000 && number < 100000 && numberStr == reversedStr)
{
    System.Console.WriteLine("True");

}
else if (number >= 10000 && number < 100000 && numberStr != reversedStr)
{
    System.Console.WriteLine("False");
}
else
{
    System.Console.WriteLine("Число не пятизначное");
    System.Console.WriteLine("False");
}
