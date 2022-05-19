/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Double[,] array = new Double[n, m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-9, 9) + new Random().NextDouble();
        Console.Write($"{Math.Round(array[i, j], 1)} ");
    }
    Console.WriteLine();
}    
