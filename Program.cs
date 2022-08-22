void FillArray(int[,] array, int row, int column)
{
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
                array[i, j] = rand.Next(0, 11);
        }
    }
}

void PrintArray(int[,] array, int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.Write("\b\b");
        Console.WriteLine();
    }
}

void Zadacha_54()
{
    int row = 4;
    int column = 4;
    int[,] array = new int[row, column];
    FillArray(array, row, column);
    PrintArray(array, row, column);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int a = 0; a < column - j - 1; a++)
            {
                if(array[i, a] < array[i, a+1])
                {
                    int temp = array[i, a];
                    array[i, a] = array[i, a+1];
                    array[i, a+1] = temp;
                }
            }
        }
    }

    Console.WriteLine();
    PrintArray(array, row, column);
}
//Zadacha_54();

int Min(int[,] array, int row)
{
    int sum = 0;
    for(int i = 0; i < row; i++)
    {
        sum += array[0, i]; 
    }
    return sum;
}

void Zadacha_56()
{
    int row = 4;
    int column = 4;
    int sum = 0;
    int[,] array = new int[row, column];
    FillArray(array, row, column);
    PrintArray(array, row, column);

    int minSum = Min(array, row);
    int indSum = 0;

    for (int i = 1; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            indSum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с минимальной суммой - {indSum + 1}");
}
//Zadacha_56();


void Zadacha_58()
{
    int row = 4;
    int column = 4;
    int[,] array = new int[row, column];
    int sum = 4;
    int rowOne = 0;
    int columnOne = 0;
    int peremOne = 0;
    int peremTwo = 1;
    int steps = column;
    int turn = 0;
    for (int i = 0; i < row * column; i++)
    {
        array[rowOne, columnOne] = i + 1;
        steps--;
        if(steps == 0)
        {
            steps = row - 1 - turn/2;
            int temp = peremOne;
            peremOne = peremTwo;
            peremTwo = -temp;
            turn++;
        }
        rowOne += peremOne ;
        columnOne += peremTwo;
    }
    Console.WriteLine();
    PrintArray(array, row, column);
}
Zadacha_58();