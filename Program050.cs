// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

//---------------БЛОК ОПИСАНИЙ----------------------
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
    int[,] arr = new int[row, columns];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(0, 100);
        }
    return arr;
}

bool GetResult(int row, int columns, int[,] arr)
{
    if (row <= arr.GetLength(0) && columns <= arr.GetLength(1))
        return true;
    else 
        return false;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i,j]} ");
        Console.WriteLine();
    }   
}


void PrintResult(bool result, int rowNum, int columnsNum, int[,] arr)
{
    if (result)
        Console.WriteLine($"Значение элемента массива с индексом [{rowNum},{columnsNum}] -> {arr[rowNum - 1,columnsNum - 1]}");
    else
        Console.WriteLine($"{rowNum},{columnsNum} -> такого числа нет");
}
//--------------------------------------------------
Console.Clear();

int rows = GetSizeArray("Введите количество строк массива - ", "Ошибка ввода!");        // Определяем размер
int columns = GetSizeArray("Введите количество столбцов массива - ", "Ошибка ввода!");  // массива.
int rowNum = GetSizeArray("Введите номер строки массива - ", "Ошибка ввода!");          // Ввод номера (не индекса!) строки и
int columnsNum = GetSizeArray("Введите номер столбца массива - ", "Ошибка ввода!");     // столбца массива.
int[,] array = GetArray(rows, columns);
bool result = GetResult(rowNum, columnsNum, array);
PrintArray(array);
PrintResult(result, rowNum, columnsNum,array);
