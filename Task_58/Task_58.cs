// Программа задает две матрицы и выводит результат их умножения.
// Матрицы генерируются совместные.

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

int[,] MultiplyArray(int[,] arrayM1, int[,] arrayM2)
{
    int[,] result=new int[arrayM1.GetLength(0), arrayM2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < arrayM1.GetLength(1); k++)
            {
                result[i,j]+=arrayM1[i,k]*arrayM2[k,j];
            }
        }
    }
    return result;
}

Console.Clear();
int rows = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);
int[,] array = GetArray(rows, columns);
Console.WriteLine("Сгенерированный массив 1");
PrintArray(array);
int rows1 = columns;
int columns1 = new Random().Next(2, 11);
int[,] array1 = GetArray(rows1, columns1);
Console.WriteLine("Сгенерированный массив 2");
PrintArray(array1);
int[,] resultMultiply = MultiplyArray(array, array1);
Console.WriteLine("Результат умножения");
PrintArray(resultMultiply);