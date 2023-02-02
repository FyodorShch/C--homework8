/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int[,] spiral = SpiralArray(a, b, c);
PrintArray(spiral);
Console.WriteLine();

int[,] SpiralArray(int rows, int columns, int startNumberSpiral)
{
    int[,] returnSpiral = new int[rows, columns];
    int numberOfSpiral = startNumberSpiral;
    int count = 1; 
    int minRow = 0; 
    int maxRow = returnSpiral.GetLength(0) - 1;
    int minColumn = 0;
    int maxColumn = returnSpiral.GetLength(1) - 1;
    while (
        count <= returnSpiral.Length)
    {

        for (int i = minColumn; i <= maxColumn; i++)
        {
            returnSpiral[minRow, i] = numberOfSpiral++;
            count++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            returnSpiral[i, maxColumn] = numberOfSpiral++;
            count++;
        }
        maxColumn--;
        for (int i = maxColumn; i >= minColumn; i--)
        {
            returnSpiral[maxRow, i] = numberOfSpiral++;
            count++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            returnSpiral[i, minColumn] = numberOfSpiral++;
            count++;
        }
        minColumn++;

    }
    return returnSpiral;

}
