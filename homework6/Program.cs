// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];

//     Console.WriteLine("Input your numbers: ");

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i + 1} element: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine();
//     return newArray;
// }

// int FindPositiveElemenstCount(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// Console.WriteLine("Input an amount of numbers: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// Console.WriteLine($"There is {FindPositiveElemenstCount(myArray)} positive elements");






// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void CrossPoint(double k1, double k2, double b1, double b2)
{
    double k = k1-k2;
    double b = b2-b1;

    double x = b/k;
    double y2 = k2*x;
    double y = y2 + b2;
   if(k1 != k2)
   {
    Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}.{y})"); 
   }
   else
   {
    Console.WriteLine("Прямые не пересекаются");
   }
      

    
}
  

Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

CrossPoint(k1, k2, b1, b2);