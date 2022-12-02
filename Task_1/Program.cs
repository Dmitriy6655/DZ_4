// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и 
// //выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе 
// //и метод должен вернуть массив чисел.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// double number_IN = double.Parse(Console.ReadLine());

// //создаем МАССИВ:
// double[] Array =  CubeTable(number_IN);

// //вызываем МЕТОД печати массива:
// //Console.WriteLine("Array равно:");
// PrdoubleArray(Array);

// //Создаем МЕТОД для возведения в 3 степень.

// double [] CubeTable (double number_IN )
// {
//     double count = 0;
//     //double num = number_IN;
//     double number_cube = 1; 
    

// //определяем количество чисел возведенных в 3 степень от 1 до  number_IN:
//      for(double r = 1; r <= number_IN; r++)
//     {
//         number_cube = r * r * r;
//         count++;
                     
//     }
     
//      //создаем локальный массив для заполения числами
//      double [] local_array = new double[count];
     
//      //заполняем массив числами
        
//         for(double q = 1; q <= count; q++)
//         {           
            
//             local_array[q-1] = q *q *q; 
                     
//         }
    
// return local_array;
// }

// void PrdoubleArray (double[] Array)
// {
   
//     for (double s = 0; s <= Array.Length; s++)
//     {
//         Console.WriteLine($"{Array[s]}");
            
//     }
    
// Console.WriteLine();

// }

// Задача 25: Напишите программу, 
// которая принимает на вход два числа (A и B) и метод который возводит 
// число A в натуральную степень B. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать Math.Pow()

Console.Write("Введите число A: ");
double num_A = double.Parse(Console.ReadLine());
Console.Write("Введите степень числа А: ");
double power_num_A = double.Parse(Console.ReadLine());

double NumberPower (double num_A, double power_num_A )
{
double power = 0;

for(double i = 0; i<=power_num_A; i++)
{
    power = num_A * num_A;
}
return power;
}

double result = NumberPower(num_A, power_num_A );

Console.Write($"Результат равен: {result}");
