// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.

System.Console.WriteLine("Введите число 1...   ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2...   ");
int number2 = Convert.ToInt32(Console.ReadLine());

int reslt = 0;

if (number1 % number2 == 0)
{
    System.Console.WriteLine("YES");
}
else
{
    reslt = number1 % number2;
    System.Console.WriteLine(reslt);
}

