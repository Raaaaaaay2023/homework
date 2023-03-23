//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Choose a task:");
Console.WriteLine("1. task54");
Console.WriteLine("2. task56");
Console.WriteLine("3. task58");
Console.WriteLine("4. task60");
Console.WriteLine("5. task62");
int userInput = Convert.ToInt32(Console.ReadLine());
int[,] myArray = RandomArr();
int[,] myArray1 = RandomArr();
int[,,]Matrix = new int[2,2,2];
switch (userInput)
{  
    case 1:
        bubbleSort(myArray);
        break;
    case 2:
        sumCompare(myArray);
        break;
    case 3:
        arrTimes(myArray,myArray);
        break;
    case 4:
        Matrix = GetMatrix(Matrix);
        PrintMatrix(Matrix);
        break;
    case 5:
        newArray(myArray);
        break;
    default:
        Console.WriteLine("Invalid option selected.");
        break;
    }

int [,] RandomArr()
{
    Console.WriteLine("Input a number for the row of the array ");
    int row=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number for the column of the array ");
    int column=Convert.ToInt32(Console.ReadLine());
    int[,]array =new int[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(-10,11);
            Console.Write(array[i,j]+";");
        }
         Console.Write("]");
    }
    Console.WriteLine();
    return array;
}
void bubbleSort(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
{
    // Perform bubble sort on the current row
    for (int j = 0; j < myArray.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < myArray.GetLength(1); k++)
        {
            if (myArray[i, j] > myArray[i, k])
            {
                int temp = myArray[i, j];
                myArray[i, j] = myArray[i, k];
                myArray[i, k] = temp;
            }
        }
    }
}
 for (int i = 0; i < myArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
          
            Console.Write(myArray[i,j]+";");
        }
         Console.Write("]");
    }

   
}

void sumCompare(int[,] myArray)
{   
    int minSum = int.MaxValue;
    int minIndex = -1;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {   
        int sum=0;
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            sum+=myArray[i,j];
        }
        if(sum<minSum)
        {
            minSum=sum;
            minIndex=i;
        }
    }
     System.Console.WriteLine($"The smallest sum of all the rows is  {minIndex+1}");
}
void arrTimes(int[,] myArray,int[,] myArray1)
{   int rows1 = myArray.GetLength(0);
    int cols1 = myArray.GetLength(1);
    int rows2 = myArray1.GetLength(0);
    int cols2 = myArray1.GetLength(1);
    int[,] newArr = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += myArray[i, k] * myArray1[k, j];
            }
            newArr[i, j] = sum;
        }
    }

    Console.WriteLine("The times of two matrix will be:");
    for (int i = 0; i < rows1; i++)
    {   Console.Write("[");
        for (int j = 0; j < cols2; j++)
        { 
            Console.Write(newArr[i, j] + ";");
        }
        Console.Write("]");
    }
}


int[,,] GetMatrix(int[,,] Matrix)
{
  

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k <  Matrix.GetLength(2); k++)
           
             Matrix[i, j, k] = i*2+j*3+k;
            
        }
    }

    return  Matrix;
}

void PrintMatrix(int[,,] Matrix)
{

for (int i = 0; i <  Matrix.GetLength(0); i++)
{
    for (int j = 0; j <  Matrix.GetLength(1); j++)
    {
        for (int k = 0; k <  Matrix.GetLength(2); k++)
        {
            Console.Write( Matrix[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
}
}

void newArray(int[,] myArray)
{
    int value = 1;
        int minRow = 0;
        int maxRow = myArray.GetLength(0) - 1;
        int minCol = 0;
        int maxCol = myArray.GetLength(1) - 1;

        while (value <= myArray.GetLength(0) * myArray.GetLength(1))
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                myArray[minRow, i] = value++;
            }

            for (int i = minRow + 1; i <= maxRow; i++)
            {
                myArray[i, maxCol] = value++;
            }

            for (int i = maxCol - 1; i >= minCol; i--)
            {
                myArray[maxRow, i] = value++;
            }

            for (int i = maxRow - 1; i >= minRow + 1; i--)
            {
                myArray[i, minCol] = value++;
            }

            minRow++;
            maxRow--;
            minCol++;
            maxCol--;
        }

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write($"{myArray[i, j]:00} ");
            }
            Console.WriteLine();
        }
}
