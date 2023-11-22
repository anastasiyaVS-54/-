// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 999);
    }
    return array;
}

int[] userArray = GetRandomArray(123);


void PrintArray(int[] array)
{
    int resnum = 0;
    System.Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}, ");
        if(array[i] > 10 && array[i] < 100)
        {
            resnum = resnum + 1;
            // System.Console.WriteLine(resnum);
        }
    }
    System.Console.WriteLine(" ]");
    System.Console.WriteLine(resnum);
}

PrintArray(userArray);

