// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

Console.Clear();

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int[] userArray = GetRandomArray(5);

void PrintArray(int[] array)
{
    System.Console.WriteLine($"Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}     ");
        
    }
    System.Console.WriteLine();
}
PrintArray(userArray);

void CountEvenElements(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            res = res + 1;
        }
    }
    System.Console.WriteLine($"Количество четных элементов: {res}");
}

CountEvenElements(userArray);

