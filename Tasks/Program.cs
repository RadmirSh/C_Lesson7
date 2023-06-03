Console.WriteLine("Please write the number of task");

int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        task1();
        break;

    case 2:
        task2();
        break;

    case 3:
        task3();
        break;

    default:
        break;
}

void task1()
{
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

Console.WriteLine("\n");
}

void task2()
{
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
}

void task3()
{
Random randomNew = new Random();
int[,] arr = new int[randomNew.Next(1, 20), randomNew.Next(1, 20)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = randomNew.Next(1, 20);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();
}