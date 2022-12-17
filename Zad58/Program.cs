// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух
//  матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MultiplMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int Multi = 0;
      
        Multi = matrixA[i,j] * matrixB[i,j];
      
        resultMatrix[i,j] = Multi;
        Console.Write($"{resultMatrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Vvdeidte razmer matrici: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[coord[0], coord[1]];
int[,] matrixB=new int[coord[0],coord[1]];
Console.WriteLine("\nMatrica 1: ");
InputMatrix(matrixA);
Console.WriteLine("\nMatrica 2: ");
InputMatrix(matrixB);

int[,] resultMatrix = new int[coord[0],coord[1]];

Console.WriteLine("\nMatrica Proizvedenii 2 matric: ");
MultiplMatrix(matrixA,matrixB,resultMatrix);
