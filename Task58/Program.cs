// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// C[i,j] =Сумма(Строк[1]*Столбцы[2]) = А[i,j]*B[i,j] + A[i+1,j]*B[i,j+1]...

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    Console.WriteLine("Произведение матриц: ");
    int[,] MatrixMultiplied = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                MatrixMultiplied[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return MatrixMultiplied;
}


Console.Write("Введите количество строк первого массива: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int c1 = Convert.ToInt32(Console.ReadLine());
int[,] arr1 = FillArray(r1, c1);
Console.Write("Введите количество строк второго массива: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int c2 = Convert.ToInt32(Console.ReadLine());
int[,] arr2 = FillArray(r2, c2);

Console.WriteLine("Первая матрица:");
PrintArray(arr1);
Console.WriteLine("Вторая матрица:");
PrintArray(arr2);

// Если число столбцов матрицs 1 не равно числу строк матрицы 2, то их нельзя перемножать

if (c1 != r2) Console.WriteLine("Эти матрицы перемножать нельзя");
else PrintArray(MatrixMultiplication(arr1, arr2));
