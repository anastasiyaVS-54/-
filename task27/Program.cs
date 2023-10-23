// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();

void Sum()
{
    System.Console.WriteLine("Введите число: "); // 452
    int userNumber = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    while(userNumber > 0)
    {
        sum += userNumber % 10;
        userNumber = userNumber / 10;
    }
    System.Console.WriteLine(sum);
}

Sum();
























// int n1 = userNumber / 100;
// System.Console.WriteLine($"Первая цифра: {n1}");

// int m1 = userNumber / 10;
// int n2 = m1 % 10;
// System.Console.WriteLine($"Вторая цифра: {n2}");

// int n3 = userNumber % 10;
// System.Console.WriteLine($"Третья цифра: {n3}");

