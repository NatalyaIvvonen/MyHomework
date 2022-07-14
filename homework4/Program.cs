// на вход число, на выход - сумма цифр в числе.

// int SummElement(int n)
// {
//     int sum = 0;
//     int result = 0;

//     while (n > 10)
//     {
//         int ed = n % 10;
//         n = n / 10;
//         sum = sum + ed;
//     }
//     result = sum + n;
//     return result;
// }



// Console.Write("input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of elements of number {number} is {SummElement(number)}");


// создаёт массив из м элементов и выводит их на экран

int[] CreateArray(int m)
{
    int[] newArray = new int[m];
    
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


Console.Write("input a array size: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(m);
Console.Write("Your array is: ");
ShowArray(array);