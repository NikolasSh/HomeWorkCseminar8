/*
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] InitMatrix()
{
    int[,] matrix = new int[2,2];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(1,10);
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

int[,] SumMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    
    int[,] matrixResult = new int[2,2];
/*
    matrixResult[0,0] = (matrixOne[0,0]*matrixTwo[0,0]) + (matrixOne[0,1]*matrixTwo[1,0]);
    matrixResult[0,1] = (matrixOne[0,0]*matrixTwo[0,1]) + (matrixOne[0,1]*matrixTwo[1,1]);
    matrixResult[1,0] = (matrixOne[1,0]*matrixTwo[0,0]) + (matrixOne[1,1]*matrixTwo[1,0]);
    matrixResult[1,1] = (matrixOne[1,0]*matrixTwo[0,1]) + (matrixOne[1,1]*matrixTwo[1,1]); 
    return matrixResult;
*/
    for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                for (int k = 0; k < matrixTwo.GetLength(0); k++)
                {
                    matrixResult[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                    Console.WriteLine(matrixOne[i, k] * matrixTwo[k, j]);
                    Console.WriteLine(matrixResult[i,j]);
                }
                
            }
            
        }
        return matrixResult;
}



int [,] firstMatrix = InitMatrix();
PrintMatrix (firstMatrix);
int [,] secondMatrix = InitMatrix();
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
int [,] matrixSum = SumMatrix(firstMatrix,secondMatrix);
PrintMatrix(matrixSum);