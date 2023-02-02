/* Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

Console.WriteLine("Введите границы массива");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = array(a, b, min, max);
ShowArray(myArray);
MinLine(myArray);

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
void MinLine(double[,] array)
{
    double[] massive = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            massive[i] += array[i, j];
        }
    }
    double min = massive[0];
    int minIndex = 0;
    for (int k = 0; k < massive.Length; k++)
    {
        if (massive[k] < min)
        {
            min = massive[k];
            minIndex = k + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма элеентов равная {min} находится в строке {minIndex}");
}
