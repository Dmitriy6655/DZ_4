// Задача 25: Напишите программу, 
// которая принимает на вход два числа (A и B) и метод который возводит 
// число A в натуральную степень B. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать Math.Pow()

Console.Write("Введите число A: ");
double num_A = double.Parse(Console.ReadLine());
Console.Write("Введите степень числа А: ");
double power_num_A = double.Parse(Console.ReadLine());

//создаем МЕТОД и вводим в него аргументы num_A и power_num_A
double NumberPower (double num_A, double power_num_A )
{
double power = 0;

for(double i = 0; i<=power_num_A; i++)
{
    power = num_A * num_A;
}
return power;
}

//создаме переменную в которую вносим переменную 
//power из метода NumberPower
double result = NumberPower(num_A, power_num_A );

Console.Write($"Результат равен: {result}");
