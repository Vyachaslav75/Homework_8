// Программа генерирует трехмерный массив и наполняет его
// положительными двузначными числами

int[,,] GetArrayCube(int m, int n, int k, int minValue = 10, int maxValue = 99)
{
    int[,,] result = new int[m, n, k];
    int[] check = new int[m * n * k];
    Array.Fill(check, 0);
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                while (true)
                {
                    temp = new Random().Next(minValue, maxValue + 1);
                    if (Array.IndexOf(check, temp) == -1)
                    {
                        result[i, j, l] = temp;
                        check[Array.IndexOf(check, 0)] = temp;
                        break;
                    }
                }

            }

        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int l = 0; l < inArray.GetLength(2); l++)
            {
                Console.WriteLine($"{inArray[i, j, l],8}  ({i}, {j}, {l})");
            }

        }
    }
}



Console.Clear();
int rows = new Random().Next(2, 23);
int columns = new Random().Next(2, 90 / (rows * 2));
int cube = new Random().Next(2, 90 / (rows * columns));

int[,,] array = GetArrayCube(rows, columns, cube);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
