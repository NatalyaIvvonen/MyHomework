// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];

//     for(int i = 0; i < size; i++)
//         newArray[i] = new Random().Next(minValue, maxValue + 1);

//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int FindEvenElementsCount(int[] array)
// {
//     int count = 0;

//     for(int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0) count++;

//     return count;
// }

// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 999;

// int[] array1 = CreateRandomArray(size, min, max);
// ShowArray(array1);
// Console.WriteLine($"The number of even array elements is " + FindEvenElementsCount(array1));



// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int FindOddSum(int[] array)
// {
//     int sum = 0;

//     for (int i = 1; i < array.Length; i = i + 2)
//         sum += array[i];

//     return sum;
// }



// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value of element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value of element: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] array2 = CreateRandomArray(size, min, max);
// ShowArray(array2);
// Console.WriteLine($"Sum of odd position elements is {FindOddSum(array2)}");



//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

    return array;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double FindMinMax(double[] array)
{
    double min1 = array[0];
    double max1 = array[1];
    double result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < min1) min1 = array[i];
        else if(array[i] > max1) max1 = array[i];
        result = max1 - min1;

    return result;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());


double[] array3 = CreateDoubleArray(size, min, max);
ShowDoubleArray(array3);

Console.Write($"Difference between max and min is {FindMinMax(array3)}");