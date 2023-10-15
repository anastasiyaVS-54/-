//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7:   ");
int numberDay = Convert.ToInt32(Console.ReadLine());

string [] number = { "1", "2", "3", "4", "5", "6", "7" };

if (numberDay >= 1 && numberDay <= 5) 
{
    System.Console.WriteLine("Будний");
}
else if (numberDay >= 6 && numberDay <= 7)
{
    System.Console.WriteLine("Выходной");
}
else
{
    System.Console.WriteLine("Не верно введенное число");
}






//     System.Console.WriteLine("Будний");
// }




//     if(numberDay == 6 || numberDay == 7)
//     {
//         System.Console.WriteLine("Выходной");
//     }
// }
// else
// {
//     System.Console.WriteLine("Будний");
// }