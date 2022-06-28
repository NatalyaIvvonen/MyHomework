// task 1
/*
int SecondNumber()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Current number is " + num);
    
    int dec = num / 10;
    int result = dec % 10;
    return result;
    
}

int number = SecondNumber();
Console.WriteLine(number);

*/

// task 2

void ThirdNum()
{
    int num;

    Console.Write("Input a number: ");
    num = Convert.ToInt32(Console.ReadLine());
  
        while(num < 100000000)
        {
            if(num < 1000 && num > 99)
            {
                int tis = num % 10;
                Console.WriteLine(tis);
                break;
            }
            else
            {
                num = num / 10;
            }
            
        }
                 
            
            
}

ThirdNum();






// task 3
/*
bool DayNumber()
{
    int DayNum;

    Console.Write("Input a day number: ");
    DayNum = Convert.ToInt32(Console.ReadLine());

   if(DayNum == 6)
   {
        return true;
   }
    else
    {
        if (DayNum == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}

Console.WriteLine(DayNumber());

*/