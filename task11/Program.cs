//Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру из этого числа.\\

int number = new Random().Next(100, 1000);

System.Console.WriteLine(number);

int one = number / 100;
int two = number % 10;



System.Console.Write(one);
System.Console.Write(two);
