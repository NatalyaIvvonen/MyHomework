// task 1

// int SecondNumber(int num)
// {
    
    
//     int dec = num / 10;
//     int result = dec % 10;
//     return result;
    
// }
// int number = new Random().Next(100, 1000);
// Console.WriteLine("Current number is " + number);

// Console.WriteLine(SecondNumber(number));


// task 2

// void ThirdNum(int num)
// {
 
//         while(num < 1000000000)
//         {
//             if(num < 99) 
//             {
//                 Console.WriteLine("Третьей цифры нет!");
//                 break;
//             }
//             if(num < 1000 && num > 99)
//             {
//                 int tis = num % 10;
//                 Console.WriteLine(tis);
//                 break;
//             }
//             else
//             {
//                 num = num / 10;
//             }
            
//         }
                 
            
            
// }

// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// ThirdNum(number);






// task 3

bool DayNumber(int DayNum)
{
     
   if(DayNum == 6 || DayNum == 7) 
        return true;
    else
        return false;
    
}

Console.Write("Input a day number: ");
  int DayOfWeek = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DayNumber(DayOfWeek));