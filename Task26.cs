/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] SpiralFilling()
{
    int[,] spiral = new int[4,4];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= spiral.GetLength(0) * spiral.GetLength(1))
    {
        spiral[i,j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiral.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= spiral.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > spiral.GetLength(1) - 1)
        j--;
        else
        i--;
    }
    return spiral;
}


void PrintMatrix(int[,] matrix)
{
    string fmt = "00";
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {                  
                    Console.Write($"{matrix[i,j].ToString(fmt)} ");                    
                }
                
            Console.WriteLine();
        }
}

int[,] spiral = SpiralFilling();
PrintMatrix(spiral);

