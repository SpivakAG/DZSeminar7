//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] table = new int[4, 3];
FillTable(table);
void FillTable(int[,] matrix)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
        }
    }
}
PrintMatrix(table);
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int sum = 0;
for (int i = 0; i < table.GetLength(1); i++)
{
    for (int j = 0; j < table.GetLength(0); j++)
    {
        sum += table[j, i];
    }
    Console.WriteLine($"Сумма столбца {i + 1} = {sum}");
    sum = 0;
}