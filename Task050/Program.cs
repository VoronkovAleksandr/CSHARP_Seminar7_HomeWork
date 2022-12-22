// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

string ProcessingArray(int[,] arr, int row, int column)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string result = $"{row}, {column} -> такого числа в массиве нет";
    if (row < 1 || row > rows) return result;
    if (column < 1 || column > columns) return result;
    result = $"В строке {row}, столбце {column} хранится {arr[row - 1, column - 1]}";
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

int m = Convert.ToInt32(DataEntry("Введите номер строки: "));
int n = Convert.ToInt32(DataEntry("Введите номер столбца: "));
int[,] matr = new int[5, 5];
FillArray(matr, -10, 10);
PrintArray(matr);
Console.WriteLine(ProcessingArray(matr, m, n));