/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] massive = array(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
ShowArray(massive);

int[,,] array(int[] size, int min, int max)
{
    int[,,] result = new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int r = 0;
            while (r < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (findElement(result, element))
                    continue;
                result[i, j, r] = element;
                r++;
            }
        }
    }
    return result;
}
bool findElement(int[,,] massive, int el)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int r = 0; r < massive.GetLength(2); r++)
            {
                if (massive[i, j, r] == el)
                {
                    return true;
                }
            }
        }
    }
    return false;
}
void ShowArray(int[,,] array)
{

    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int r = 0; r < massive.GetLength(2); r++)
            {
                Console.WriteLine($"{array[i, j, r]} ({i},{j},{r}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}