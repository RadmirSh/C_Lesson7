// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

Console.Write("Please write raw size (m) of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please write raw size (n) of array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] randomOfArray = new int[m,n];

Console.Write("Please write raw position: ");
int positionM = Convert.ToInt32(Console.ReadLine());

Console.Write("Please write column position: ");
int positionN = Convert.ToInt32(Console.ReadLine());

void editArray(int m, int n)
{
int k,l;
Random randomNew = new Random();
    for (k = 0; k < m; k++)
    {
    Console.WriteLine();
    for (l = 0; l < n; l++)
        {
        randomOfArray[k,l] = randomNew.Next(0,99);
        Console.Write($"{randomOfArray[k,l]} ");
        }
    Console.WriteLine("\n");
    }
}

editArray(m,n);

    if (positionM<1 || positionN<1)
    Console.Write("Row positions cannot be negative");

    else if (positionM <= m+1 && positionN <= n+1)
    
    Console.Write($"The value of the element is {randomOfArray[positionM-1,positionN-1]} ");

    else Console.Write("There is no such element in the array");

