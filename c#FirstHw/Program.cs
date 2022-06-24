/*int num1, num2;

Console.Write("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num2 > num1)
{
    Console.Write("max number is " + num2 + ", ");
    Console.Write("min number is " + num1 + " ");
}
else
{
    Console.Write("max number is " + num1 + ", ");
    Console.Write("min number is " + num2 + " ");
}


int num1, num2, num3, max;

Console.Write("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if(max < num2)
{
    max = num2;
}

if(max < num3)
{
    max = num3;
}

Console.Write("max number is " + max);


int num;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num %2 == 0)
{
    Console.Write("The number is even");
}
else
{
    Console.Write("The number is odd");
}
*/

int num, current;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}