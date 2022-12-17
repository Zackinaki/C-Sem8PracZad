﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Queue<int> que = new Queue<int>(Enumerable.Range(10, 90).OrderBy(x => new Random().NextInt64()));
void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            
            Console.Write($"({i},{j},{k}) {matrix[i, j,k]= que.Dequeue()} \t");
        }
        Console.WriteLine();
    }
}
}

Console.Clear();
Console.Write("Vvdeidte razmer matrici: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[coord[0], coord[1],coord[2]];

Console.WriteLine("\nMatrica imeet vid: ");
InputMatrix(matrix);

