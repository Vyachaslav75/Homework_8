// Программа задает массив и находит строку с наименьшей суммой элементов и 
// выводит номер строки и сумму.

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

int[] LeastSumRow(int[,] array)
{
    int leastrSum = 0;
    int indexSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (leastrSum > sumRow)
        {
            leastrSum = sumRow;
            indexSum = i;
        }
    }
    int[] result={indexSum+1, leastrSum};
    return result;
}
    

Console.Clear();
int rows = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);
int[,] array = GetArray(rows, columns);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
int[] result=LeastSumRow(array);
Console.WriteLine($"Строка с наименьшей суммой номер {result[0]} сумма {result[1]}");