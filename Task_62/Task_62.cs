// Программа спирально заполняет массив заданного размера.

int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
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


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    int count = 1;
    int i = 0;
    int j = 0;
    string direct = "right";
    int countRight = 0;
    int countLeft = 0;
    int countDown = 0;
    int countUp = 0;
    
    while (count <= m * n)
    {
        result[i, j] = count;
        if (direct == "right") { j++; }
        else if (direct == "left") { j--; }
        else if (direct == "down") { i++; }
        else if (direct == "up") { i--; }
        count++;
        
        if (j == n - countRight - 1 && direct=="right")
        {
            direct = "down";
            countRight++;
        }
        else if (j == 0 + countLeft && direct=="left")
        {
            direct = "up";
            countLeft++;
        }
        else if (i == m - countDown - 1 && direct=="down")
        {
            direct = "left";
            countDown++;
        }
        else if (i == 1 + countUp && direct=="up")
        {
            direct = "right";
            countUp++;
        }
    }
    return result;
}

Console.Clear();
// int rows = new Random().Next(2, 11);
// int columns = new Random().Next(2, 11);
// int[,] array = GetArray(rows, columns);
// Console.WriteLine("Спирально заполненный массив");
// PrintArray(array);
int userRow = enterNumber("Введите количество строк:  ", "Введите целое число");
int userColumn = enterNumber("Введите количество столбцов:  ", "Введите целое число");
int[,] array = GetArray(userRow, userColumn);
Console.WriteLine("Спирально заполненный массив");
PrintArray(array);
