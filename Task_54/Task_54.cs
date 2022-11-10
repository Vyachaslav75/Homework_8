int[,] GetArray(int m, int n, int minValue = -99, int maxValue = 99)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j],8} ");
        }
        Console.WriteLine();
    }
}

void SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        bool change = false;
        while (true)
        {
            if (array[i, j] < array[i, j + 1])
            {
                (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                change = true;
            }
            j++;
            if (j == array.GetLength(1) - 1)
            {
                if (!change)
                {
                    break;
                }
                else
                {
                    j=0;
                    change=false;
                }
                
            }
        }
    }
}



Console.Clear();
int rows = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);
int[,] array = GetArray(rows, columns);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
SortArrayRows(array);
Console.WriteLine("Отсортированный массив");
PrintArray(array);