// на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), 
// разделеные знаком табуляции.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int count = 1; count <= number; count++)
{
    if(count % 2 == 0)
    {
        int res = count;
        System.Console.Write(res + "    ");
    }
}
