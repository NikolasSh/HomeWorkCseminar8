/*
Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] InitMatrix()
{
    int[,] matrix = new int[3,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(1,100);
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

int[,] DescendingNumbers(int[,] matrix)
{
    int number = 0;
    
    
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {                                
                    for (int k = matrix.GetLength(1)-1; k >= 0; k--)
                    {
                        if (matrix[i,j] < matrix[i,k] && k > j)
                        {
                            number = matrix[i,j];
                            matrix[i,j] = matrix[i,k];
                            matrix[i,k] = number;
                        }
                    }
                            
                           
                }
                
        }
    return matrix;
}




int [,] matrix = InitMatrix();
PrintMatrix (matrix);
int [,] descending = DescendingNumbers(matrix);
Console.WriteLine();
PrintMatrix(descending);
