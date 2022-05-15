//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int m = NumberCheck("Введите количество строк массива");
int n = NumberCheck("Введите количество столбцов массива");
int NumberCheck(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number <= 0)
    {
        Console.WriteLine("Введенное число не является натуральным, повторите попытку ввода");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
int[,] table = new int[m, n]; //тип должен быть double, узнать как делаь корректный рандом
FillTable(table);
void FillTable(int[,] matrix)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99, 99);
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
