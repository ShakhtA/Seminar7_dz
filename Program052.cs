// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//----------БЛОК ОПИСАНИЙ------------------
int GetSizeArray(string messageNumber, string errorMessage)
{
    int sizeArray = 0;
    while (true)
    {
        Console.Write(messageNumber);
        if (int.TryParse(Console.ReadLine(), out sizeArray) && sizeArray > 0)
            return sizeArray;
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int row, int columns)
{
    int[,] arr = new int[row,columns];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < columns; j++)
            arr[i,j] = new Random().Next(1, 100);
    return arr;
}

double[] GetAvgSumArray(int[,] arr)
{   
    double[] avgsumarray = new double[arr.GetLength(1)];
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
            sum += arr[i,j];
        avgsumarray[j] = (double)sum / arr.GetLength(0);
    }
    return avgsumarray;
}

void PrintResult(int[,] arr, double[] avgsum)
{
    for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                Console.Write($"{arr[i,j]} ");
            Console.WriteLine();
        }
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < avgsum.GetLength(0); i++)
        Console.Write($"{avgsum[i]:f1} ");
}
//-------------------------------------------
Console.Clear();
int rows = GetSizeArray("Введите количество строк массива - ", "Ошибка ввода!");        // Определяем размер
int columns = GetSizeArray("Введите количество столбцов массива - ", "Ошибка ввода!");  // массива.
int[,] array = GetArray(rows, columns);
double[] arrayAvgSum = GetAvgSumArray(array);   // Функция создает массив средних арифметических
                                                // элементов каждого столбца исходного массива.
PrintResult(array, arrayAvgSum);