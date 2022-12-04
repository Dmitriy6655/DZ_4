// Задача 29: Напишите программу, которая задаёт массив из 
//8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите 8 чисел массива");
Console.Write("Введите 1 число: ");
bool num1 = int.TryParse(Console.ReadLine(), out int N_1);

Console.Write("Введите 2 число: ");
bool num2 = int.TryParse(Console.ReadLine(), out int N_2);

Console.Write("Введите 3 число: ");
bool num3 = int.TryParse(Console.ReadLine(), out int N_3);

Console.Write("Введите 4 число: ");
bool num4 = int.TryParse(Console.ReadLine(), out int N_4);

Console.Write("Введите 5 число: ");
bool num5 = int.TryParse(Console.ReadLine(), out int N_5);

Console.Write("Введите 6 число: ");
bool num6 = int.TryParse(Console.ReadLine(), out int N_6);

Console.Write("Введите 7 число: ");
bool num7 = int.TryParse(Console.ReadLine(), out int N_7);

Console.Write("Введите 8 число: ");
bool num8 = int.TryParse(Console.ReadLine(), out int N_8);



int j =0;
//проверка введеных значений
while(j==0)
{
  if (!num1 || !num2 || !num3 || !num4 || !num5|| !num6|| !num7|| !num8 )
{
  Console.WriteLine("Одно или несколько введеных значений не корректно!"); 
  break;
}
else 
{
 j = 1; 
 }
}

void PrintArray (int N_1, int N_2, int N_3, 
                int N_4, int N_5, int N_6,
                int N_7, int N_8)
{
    int count = 8;
    int [] array = new int[count];
    array[0] = N_1;
    array[1] = N_2;
    array[2] = N_3;
    array[3] = N_4;
    array[4] = N_5;
    array[5] = N_6;
    array[6] = N_7;
    array[7] = N_8;

    for(int i = 0; i <count; i++)
    {
        if (i == 0)
        {
           Console.Write("[ ");
        }
        
        if (i <= 6)
        {
        Console.Write($"{array[i]}, ");
        }
                      
        if (i == 7)
        {
           Console.Write($"{array[i]} ]");
        }
    }
    
}

if (j == 1)
{
PrintArray(N_1, N_2, N_3, N_4, 
           N_5, N_6, N_7, N_8);
}