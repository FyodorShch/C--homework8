/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

Console.WriteLine("Введите количество строк 1 матрицы");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 2 матрицы");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы");
int column2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите границы значений в матрице");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(column1!=row2)
{
    Console.WriteLine("Такие матрицы нельзя умножать");
}
else
{
int[,] array1 = array(row1, column1, min, max);
ShowArray(array1);
Console.WriteLine();
int[,] array2 = array(row2, column2, min, max);
ShowArray(array2);
Console.WriteLine();
ShowArray(matrix(array1,array2));
}

int[,] array(int size1, int size2, int min, int max)
{
    int[,] massiv = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            massiv[i, j] = new Random().Next(min, max + 1);
        }
    }
    return massiv;
}
void ShowArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]:f5} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix(int[,] massiv1, int[,] massiv2)
{
    int[,] multiMatrix = new int[massiv1.GetLength(0), massiv2.GetLength(1)];
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for (int y = 0; y < massiv1.GetLength(1); y++)
            {
                multiMatrix[i, j] += massiv1[i, y] * massiv2[y, j];
            }
        }
    }
    return multiMatrix;
}