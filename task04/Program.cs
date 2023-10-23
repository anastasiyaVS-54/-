// // принимает два числа и выводит, какое число большее, а какое меньшее.

// На входе:
// firstNumber: '5'
// secondNumber: '6'

// На выходе:
// Первое число `5` меньше чем второе число `6`

System.Console.WriteLine("firstNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine(''));
System.Console.WriteLine("secondNumber: ");
int secondNumber = Convert.ToInt32(Console.ReadLine(''));

if(firstNumber < secondNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
else if(secondNumber < firstNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
}
else
{
    System.Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}
