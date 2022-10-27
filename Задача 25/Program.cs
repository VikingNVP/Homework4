//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = FindValues(a);
Console.WriteLine(result);

int FindValues(int a)
{
    int comp = a;
    for(int i = 1; i < b; i++)
    {
        comp *= a;
    }
    return comp;
}

