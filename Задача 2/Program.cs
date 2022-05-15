//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
int m = NumberCheck("Введите индекс строки искомого элемента");
int n = NumberCheck("Введите индекс столбца искомого элемента");
int NumberCheck(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 0)
    {
        Console.WriteLine("Введенное число не является натуральным, повторите попытку ввода");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

int[,] table = new int[4, 3];
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

if (m > table.GetLength(0)-1 || n > table.GetLength(1)-1) Console.WriteLine("Такого элмемента не существует");
else Console.WriteLine($"Элемент массива, c индексом {m} {n} это {table[m,n]}");