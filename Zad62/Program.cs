// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void InputMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Vvdeidte razmer matrici: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];

int start = 1;
int i = 0;
int j = 0;

while (start <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = start;
  start++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else 
  if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else 
  if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

Console.WriteLine();
InputMatrix(matrix);

