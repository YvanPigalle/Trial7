//47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double [,] CreateArray ()
{
    Console.WriteLine ("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double [,] Created2Array = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Created2Array[i,j] = Convert.ToDouble(new Random().Next(1, 10));
        }
    }
    return Created2Array;
}

void Print2Array (double [,] array2d) 
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
          Console.Write(" ▌ ");
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write (array2d[i,j] + " ▐ "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}

double [,] new2Array = CreateArray();
Print2Array(new2Array);
*/

//50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine ("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [rows,columns];

Console.WriteLine("Input number of row: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of column: ");
int m = Convert.ToInt32(Console.ReadLine());

FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("There is no such element.");
}
else
{
    Console.WriteLine($"The element from {n} row {m} column is {numbers[n-1,m-1]}");
}

Print2Array(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 10);
            }   
        }
}

void Print2Array (int [,] array2d) 
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
          Console.Write(" ▌ ");
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write (array2d[i,j] + " ▐ "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}
*/

//52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ▌ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ▐ ");
        }
        Console.WriteLine(" ");
    }
}


Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, cols];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = Math.Round((avarage / rows), 2);
    Console.Write ($" [{avarage}] ");
}
Console.WriteLine();
PrintArray(numbers);
