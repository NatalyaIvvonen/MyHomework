// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] CreateRandom2dDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows,columns];
    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 2);
    
    return array;
}

void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}



// Console.Write("Input the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dDoubleArray(rows, columns, min, max);
// Show2dDoubleArray(myArray);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();

    }
}

void FindElement(int[,] array, int row, int column)
{
    int x = row - 1;
    int y = column - 1;

    if(x <= array.GetLength(0) && y <= array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(i == x && j == y) Console.WriteLine($"Нужный элемент: {array[i,j]}");
                }
        }
    }
    else Console.WriteLine("Такого элемента нет!");
}


Console.Write("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the element's row number: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the element's column number: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] myArray1 = CreateRandom2dArray(rows, columns, min, max);
// Show2dArray(myArray1);
// FindElement(myArray1, row, column);

// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void FindAverageColumn(int[,] array)
{
    

    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double ave = 1;
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Math.Round(sum += array[i,j],1);
            
        }
        Math.Round(ave = sum/array.GetLength(0),1);
        Console.Write($"{ave}, ");
    }
    
}

int[,] myArray2 = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray2);
FindAverageColumn(myArray2);
