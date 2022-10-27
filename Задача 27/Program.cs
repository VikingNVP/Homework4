// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if(!isParsed){
    Console.WriteLine("Ошибка! Не правильный ввод данных");
    return;
}
int result = GetSumNumbers(a);
Console.WriteLine("Сумма чисел = "+ result);


int GetSumNumbers(int a)
{
    int b = 0;
    int sum = 0;
    while(a > 0){
        b = a % 10;
        sum += b;
        a = a / 10;
    }
    return sum;
}
