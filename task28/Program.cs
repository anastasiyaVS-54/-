// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();


System.Console.WriteLine("Введите число:  ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Resut(int number) //  number = 4
{    
    for (int count = 1; count <= number; count = count * count + 1);
}
return count;

int userCount = Result(userNumber);
System.Console.WriteLine(userCount);