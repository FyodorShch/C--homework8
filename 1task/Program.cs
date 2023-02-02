/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();
Console.WriteLine("Введите границы массива");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
double[,] massive = array(a, b, min, max);
ShowArray(massive);
Console.WriteLine();
double[,] orderedArray = OrderOfArray(massive);
ShowArray(orderedArray);

double[,] array(int size1, int size2, int min, int max)
{
    double[,] massiv = new double[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            massiv[i, j] = new Random().NextDouble() * (max - min);
        }
    }
    return massiv;
}
void ShowArray(double[,] massive)
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
double[,] OrderOfArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int q = j+1; q < arr.GetLength(1); q++)
            {
                if (arr[i, q] > arr[i, j])
                {
                    double p = arr[i, j];
                    arr[i, j] = arr[i, q];
                    arr[i, q] = p;
                }
            }
        }
    }
    return arr;
}