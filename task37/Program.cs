// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

Console.Clear();

int[] GetRandomaArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

int[] userArray = GetRandomaArray(4);

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}, ");
    }
    System.Console.WriteLine(" ]");
}

PrintArray(userArray);

int ProductofNumbers(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length -1; i++)
    {
        res = array[i] * array[-1];
    }
    return res;
}

int productNumbers = ProductofNumbers(userArray);
System.Console.WriteLine(productNumbers);