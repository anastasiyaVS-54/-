// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] GetRandArray(int size) // size - аргумент опр. размер массива который будет создан
{
    int[] array = new int [size]; // массив array = new int(выделяет память для массива)[size] с указанным размером
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"{arr[i]}, ");
    }
}

int[] userArray = GetRandArray(9);
PrintArray(userArray);