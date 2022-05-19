Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
double[] summ = new double[n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++) 
    {
        array[i, j] = new Random().Next(1, 10); 
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}   

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++) 
    {
        summ[i] = summ[i] + array[i, j]; 
    }
}
Console.Write($"Среднее арифметическое элементов в каждой строке: ");

for (int i = 0; i < n; i++)
{
    Console.Write($"{Math.Round(summ[i] / m,1)} ");
}
Console.WriteLine();
