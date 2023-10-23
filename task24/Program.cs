Console.Clear();

// // взять число, найти его квадрат и вычислить корень квадратный из получившегося числа

// int usera = 4;

// double Num(int a)
// {
//     double result = Math.Pow(a, 2);
//     return result
// }

// void Num1(int a)
// {
//     double result = Math.Pow(a, 2);
//     System.Console.WriteLine(result);
// }

// double userresult = Num(usera);
// double root = Math.Sqrt(Num1(usera));
// System.Console.WriteLine(root);
// System.Console.WriteLine(userresult);

// Num1(usera);

// System.Console.WriteLine(result);
////////////////////////////////////////////////////////////////////////////////////////////////////
// 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.WriteLine("Введите число: ");

int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= A; i++)
{
    sum = sum + i;
}
System.Console.WriteLine(sum);

































/// 

// System.Console.WriteLine("Введите число:  ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// int Result(int number)
// {
//     int count = 0;
//     for (int i = number; i > 0; i /= 10)
//     {
//         count = count + 1;
//     }
//     return count;
// }
// int userCount = Result(userNumber);
// System.Console.WriteLine(userCount);