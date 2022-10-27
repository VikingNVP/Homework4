// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Задание должно быть выполнено в методах.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] arr = GenerateArray();

int[] GenerateArray()
{
    int[] arr = new int[8];
    Random random = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 100);
    }
    return arr;
}
void PrintArray(int[] bla)
{
    int a = bla.Length;
    for(int i = 0; i < a; i++){
        Console.Write(bla[i]);
        Console.Write(", ");
    }
}
Console.Write("Array[");
PrintArray(arr);
Console.Write("]");
