// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

// //функция получения числа 
// void DataInput()
// {
//     System.Console.WriteLine("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
// }
// DataInput();




// функция заполнения массива
int[] GetRandomArray(int size)
{   
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}   
int[] userArray = GetRandomArray(6);

//функция вывода массива
void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}, ");
    }
    System.Console.Write(" ]");
}
PrintArray(userArray);

//запрос пользовательского числа

System.Console.WriteLine("Введите число: ");

int DataInput()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int userNumber = DataInput();

// функция нахождения числа в массиве
void IndexArray(int[] array, int find) // сам массив, число пользователя
{
    for (int i = 0; i < array.Length; i++)
    {
        int resnum = 0;
        if(array[i] == find)
        {
            resnum = array[i];
            System.Console.WriteLine("yes");
            
        }
        else
        {
            System.Console.WriteLine("no");
            
        }
    }
    
}

IndexArray(userArray, userNumber);
