// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)


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

int[] TurnArray(int[] array)
{
    int temporary 
    for (int i = 0; i < array.Length; i++)
    {
        
    }
}