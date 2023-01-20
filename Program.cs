// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
int[,] array = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine("            ");
for (int j = 0; j < 4; j++)
{
    double sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum = sum + array[i, j];
    }
    Console.Write($"{sum / 3}");
}
