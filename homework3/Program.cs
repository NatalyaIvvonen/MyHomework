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



// кубы  чисел от 1 до n

void CubeNumber(int n)
{
    int current, cube;

    current = 1;

    while(current <= n)
    {
        cube = current*current*current;
        Console.Write(cube + " ");
        current++;
    }
}

Console.WriteLine("Input your number, please: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeNumber(number);