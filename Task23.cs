/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] InitMatrix()
{
    int[,] matrix = new int[5,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(1,20);
                }
        }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
            Console.WriteLine();
        }
}

int SumFirstString(int [,] matrix)
{
    int firstSum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            firstSum = matrix[i,j] + firstSum;
        }
    }
    return firstSum;
}

int MinSumString(int[,] matrix)
{
    int minSum = SumFirstString(matrix);
    
    int sum = 0;
    int sumIndex = 0;
    int minSumIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
            sumIndex = i;
            
        }
        if (minSum >= sum)
        {
            minSum = sum;
            minSumIndex = sumIndex+1;
        }
        
        sum = 0;
   }

    return minSumIndex;
}



int [,] matrix = InitMatrix();
PrintMatrix (matrix);
int result = MinSumString(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в {result} строке.");