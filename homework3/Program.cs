//задача про палиндром
// bool Palindrom(int DesTis, int Tis, int sotni, int des, int ed)
// {
//     if(DesTis == ed && Tis == des)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
        
// }


// void CutNumber(int num)
// {
    
//     int DesTis = num / 10000; 
//     int Tis = (num % 10000)/1000; 
//     int sotni = (num % 1000)/100; 
//     int des = (num % 100)/10; 
//     int ed = num % 10; 

//     Console.Write(Palindrom(DesTis, Tis, sotni, des, ed));
// }

// Console.WriteLine("Input your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > 10000 && number < 1000000) 
// {
//     CutNumber(number);
// }
// else
// Console.WriteLine("Uncorrect number! Enter number from 10000 to 99999");

// другим способом

// void Palindrom(string num)
// {
//     if (num[0] == num[4] && num[1] == num[3]) 
//         Console.Write("Your number is a palindrome");
//     else
//         Console.Write("Your number isn't a palindrome");
// }


// Console.WriteLine("Enter a five-digit number: ");
// string number = Console.ReadLine();
// Palindrom(number);

// кубы  чисел от 1 до n

// void CubeNumber(int n)
// {
//     int current;
//     double cube;

//     current = 1;

//     while(current <= n)
//     {
//         cube = Math.Pow(current, 3);                  
//         Console.Write($"{cube} ");
//         current++;
//     }
// }

// Console.WriteLine("Input your number, please: ");
// int number = Convert.ToInt32(Console.ReadLine());

// CubeNumber(number);