// принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите по очереди три числа: ");
int a = Convert.ToInt32(Console.ReadLine()); // 5
int b = Convert.ToInt32(Console.ReadLine()); // 6
int c = Convert.ToInt32(Console.ReadLine()); // 7

int max = a;

if(b > max && b > c)
{
    max = b;
    System.Console.WriteLine(max);
}
else if(c > max && c > b)
{
    max = c;
    System.Console.WriteLine(max);
}
else
{
    max = a;
    System.Console.WriteLine(max);
}