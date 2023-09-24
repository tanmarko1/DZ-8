// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void FillArray(int[,] array){ 
//     for (int i = 0; i < array.GetLength(0); i++) 
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i, j] = new Random().Next(1, 10); 
// } 
// void PrintArray(int[,] array){ 
//     for (int i = 0; i < array.GetLength(0); i++){ 
//         for (int j = 0; j < array.GetLength(1); j++) 
//             System.Console.Write($"{array[i, j],2}    "); 
//         System.Console.WriteLine(); 
//     } 
// }  
// void SortArray(int[,] array){  
//     for (int i = 0; i < array.GetLength(0); i++){
//                 for (int j = 0; j < array.GetLength(1); j++)
//                     for (int k = 0; k < array.GetLength(1); k++){
//                         if (array[i, j] <= array[i, k]) continue;
//                         int temp = array[i, j];
//                         array[i, j] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
// } 
// System.Console.WriteLine("Введите количество строк:"); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите количество столбцов:"); 
// int cols = Convert.ToInt32(Console.ReadLine()); 
// int[,] array = new int[rows, cols]; 
// FillArray(array); 
// PrintArray(array); 
// SortArray(array); 
// System.Console.WriteLine(); 
// PrintArray(array);

// ________________________________
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:"); 
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(m, n);
Console.WriteLine();
PrintArray(array);

void FillArray(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(1, 9);
        }
    }
}
void PrintArray(int[,] array)
{
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{ array[i, j]} ");
}
Console.WriteLine();
}
}
int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    if (sum > SumLine(array, i))
    {
        sum = SumLine(array, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: { minSum}");