// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
// x=34; y=-30 -> 4 
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

string Func(int x, int y)
{
    if (x > 0  && y > 0)
        return "1";
    else if (x < 0  && y > 0)
        return "2";
    else if (x < 0  && y < 0)
        return "3";
    return "4";
}
 

System.Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Func(x, y));