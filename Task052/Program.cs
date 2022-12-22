// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


string ProcessingArray(int[,] arr, int row, int column)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string result = "Среднее арифметическое каждого столбца: ";
    double sum = 0;
    double average = 0;
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum += arr[i, j];
        }
        average = Math.Round (sum/rows,2);
        result += $"[{average}] ";
        sum = 0;
    }
    return result;
}

void PrintArray(int[,] matr)
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{matr[i, j]}] ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int minValue, int maxValue)
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int m = Convert.ToInt32(DataEntry("Введите количество строк массива: "));
int n = Convert.ToInt32(DataEntry("Введите количество столбцов массива: "));
int[,] matr = new int[m, n];
FillArray(matr, 0, 10);
PrintArray(matr);
Console.WriteLine(ProcessingArray(matr, m, n));