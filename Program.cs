// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Pleae inter a number so that we can calculate its recursion");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {num} -> \"");
// recur(num);
// void recur(int num)
// {
//     if(num!=1)
//     {
        
//         Console.Write(num+",");
//         recur(num-1);
//     }
//     else 
//         Console.Write("1");
// }
// Console.Write($"\"");



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.WriteLine("Pleae inter a number as a beginning number  so that we can calculate its recursion");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pleae inter another number as an ending number so that we can calculate its recursion");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sum =calRecur(num1,num2);
// Console.WriteLine("Sum of natural numbers from " + num1 + " to " + num2 + " is " + sum);
// int calRecur(int num1,int num2)  
//  {   
//     if(num1==num2)
//     {
//         return num1;
//     }
//     else
//     {
//         return num1+calRecur(num1+1,num2);
//     }
//  }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Pleae inter a number as an index for Ackerman");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pleae inter another number as an index for Ackerman");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(m, n);
Console.WriteLine("Ackermann function for m=" + m + " and n=" + n + " is " + result);
int AckermannFunction(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if (n == 0) {
            return AckermannFunction(m - 1, 1);
        } else {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
}






