/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/

int n = new Random().Next(3, 9);
int m = new Random().Next(3, 9);
int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
int InputNumber(string number)
{
    Console.Write($"Введите номер {number}: ");
    return
    Convert.ToInt32(Console.ReadLine());
}
int num1 = InputNumber("Укажите позицию элемента  строки");
int num2 = InputNumber("Укажите позицию элемента  столбца");

if (num1 >= array.GetLength(0) || num2 >= array.GetLength(1))
Console.Write($"Такое число отсутствует "); 
//int input = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (num1 == i && num2 == j)
        {
            Console.Write($"Значение введенного элемента = {array[i, j]} "); break;
        }
    }
}                   