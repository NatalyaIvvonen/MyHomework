int num1, num2;

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
