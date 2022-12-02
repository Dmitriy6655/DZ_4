// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int result = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе равна: {result}");


//МЕТОД сложения цифр в числе
int SumDigits (int num)
{
    int sum = 0;
    int temporary_variable = 0;

    while (num > 0)
    {
        temporary_variable = num % 10;
        num = num / 10;
        sum = temporary_variable + sum;
             
    }
    return sum;
}
