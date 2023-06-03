// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Please write raw size (m) of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please write column size (n) of array: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] randomOfArray = new double[m,n];

void editArray(int m, int n)
{
int k,l;
Random randomNew = new Random();
    for (k = 0; k < m; k++)
    {
    Console.WriteLine();
    for (l = 0; l < n; l++)
        {
        randomOfArray[k,l] = randomNew.NextDouble();
        Console.Write($"{randomOfArray[k,l]:F2} ");
        }

    }

}

editArray(m,n);