// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();


System.Console.WriteLine("Введите число:  ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Result(int number) // имя Функции( имя новой переменной)
 {                     // тело функции
    int count = 0;     // объявляем новую переменную - счетчик 
     for (int i = number; i > 0; i /= 10) // цикл for. новая перем. i = '78'; i > 0 ? - условие; когда выполнилось
                                          // i /= 10 делаем это (78/ 10 = )
     {
         count = count + 1;    // 
     }
    return count;
}
int userCount = Result(userNumber);
System.Console.WriteLine(userCount);