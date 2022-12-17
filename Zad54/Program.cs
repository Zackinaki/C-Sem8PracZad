// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


void OrderLinesMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j =0 ; j < matrix.GetLength(1); j++)
    {
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            
    for (int k = 0; k < matrix.GetLength(1)-1; k++)
    {
    for (int n = k+1; n < matrix.GetLength(1); n++)
    {
        
        if (matrix[l, k] <= matrix[l, n])
        {
          int max = matrix[l, n];
          matrix[l, n] = matrix[l, k];
          matrix[l, k] = max;
        }
        
        }
     
    }
   
  }
   
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
  }
}


Console.Clear();
Console.Write("Vvdeidte razmer matrici: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine("\n\n");
OrderLinesMatrix(matrix);
