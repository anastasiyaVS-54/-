// : Напишите программу, которая
// принимает на вход координаты двух
// точек и находит расстояние между ними в
// 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

System.Console.WriteLine("Введите координаты: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);

System.Console.WriteLine(d);