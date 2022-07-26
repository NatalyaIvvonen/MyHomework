// 1.  Задайте значение N. Напишите программу, которая найдет 
// кол-во цифр в числе N рекурсивным методом.

int CountOfDigits(int n)
{
   
    if (n >= 10)
    {
       return 1 + CountOfDigits(n/10);
         
    }
    else return 1;
}

// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(CountOfDigits(number));


// 2.Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.


int SumOFElements(int m, int n)
{
    if (n > m)
    {
        return m + SumOFElements(m+1,n);
    }
    else return n;
}

Console.WriteLine("Input a min number : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max number : ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The summ of elements from {min} to {max} is {SumOFElements(min, max)}");

