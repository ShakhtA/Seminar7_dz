/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
   m = 3, n = 4.
   0,5     7    -2  -0,2
     1  -3,3     8  -9,9
     8   7,8  -7,1     9
*/

//------------------БЛОК ОПИСАНИЙ-----------------
int GetSizeArray(string messageNumber, string errorMessage)
{
    int sizeArray = 0;
    while (true)
    {
        Console.Write(messageNumber);
        if (int.TryParse(Console.ReadLine(), out sizeArray))
            return sizeArray;
        Console.WriteLine(errorMessage);
    }
}

double[,] GetArray(int row, int columns, int minValue, int maxValue)
{
    double[,] array = new double[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]:f2}  ");
        }
        Console.WriteLine();
    }
}
//---------------------------------------------------
Console.Clear();
int rows = GetSizeArray("Введите количество строк массива - ", "Ошибка ввода!");
int columns = GetSizeArray("Введите количество столбцов массива - ", "Ошибка ввода!");
int minValue = GetSizeArray("Введите минимальное число массива - ", "Ошибка ввода!");
int maxValue = GetSizeArray("Введите максимальное чисо массива - ", "Ошибка ввода!");
double[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
