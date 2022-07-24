// 1.Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);

//     return newArray;
// }

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();

    }
}


// int[,] MinElementsInRowSorter(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i,k+1] < array[i,k])
//                 {
//                     int temp = array[i,k+1];
//                     array[i,k+1] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }


// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Console.WriteLine();
// Show2dArray(MinElementsInRowSorter(myArray));

// 2.Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int SumOfElementsInRow(int[,] array, int i)
// {
//     int sum = array[i,0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i,j];      
//     }
//     return sum;   
// }


// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray1 = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray1);

// int iMin = 0;
// int sum = SumOfElementsInRow(myArray1, 0);
// for (int i = 1; i < myArray1.GetLength(0); i++)
// {
//     int tempSum = SumOfElementsInRow(myArray1, i);
//     if (tempSum < sum)
//     {
//         sum = tempSum;
//         iMin = i;
//     }
// }

// Console.WriteLine($"Min summ of elements in row {iMin+1}");



//  3.Заполните спирально массив 4 на 4

int[,] Spiral ()
{
    int n = 4; 
    int m = 4;
    int[,] array = new int[n,m];

    int f = array.GetLength(0) - 1;
    int w = array.GetLength(1) - 1;

    int number = 0;
    int i = 0;
    int j = 0;
    int p = 0;

    while (number != array.GetLength(0)*array.GetLength(1)-1)
    {
        while (j < w)
        {
            array[i,j] = number++;
            j++;
        }

        while (i < f)
        {
            array[i,j] = number++;
            i++;
        }
    
        while (j > p)
        {
            array[i,j] = number++;
            j--;
        }
    

        f--;
        w--;
        p++;
        while (i > p)
        {
            array[i,j] = number++;
            i--;
        }
    }

     if (number == array.GetLength(0)*array.GetLength(1)-1) array[i,j] = number++;
    return array;
}

Show2dArray(Spiral ());

