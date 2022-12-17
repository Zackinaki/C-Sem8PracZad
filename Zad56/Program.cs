// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
//  элементов: 1 строка

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

Console.Clear();
Console.Write("Vvdeidte razmer matrici: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);

int minSummLine = 0;

int SummLineElements(int[,] matrix, int i)
{
  int summLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    summLine =summLine+matrix[i,j];
  }
  return summLine;
}

int summLine = SummLineElements(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int aSummLine = SummLineElements(matrix, i);
  if (summLine > aSummLine)
  {
    summLine = aSummLine;
    minSummLine = i;
  }
}

Console.WriteLine($"\nStroka № {minSummLine+1} emmet naimenshiu summu elementov ({summLine})");






