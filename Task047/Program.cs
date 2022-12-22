// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void PrintArray(double[,] matr)
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

void FillArray(double[,] matr, int minValue, int maxValue)
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int m = Convert.ToInt32(DataEntry("Введите m: "));
int n = Convert.ToInt32(DataEntry("Введите n: "));
double[,] matr = new double[m, n];
FillArray(matr, -10, 10);
PrintArray(matr);
