// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк и столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int x = 1;
int[,] array = new int[m, n];

for (int j = 0; j < n; j++)
{
    for (int i = 0 + j; i <= m - 1 - j; i++)
    {
        array[0 + j, i] = x;
        x++;
    }
    x--;
    for (int i = 0 + j; i < m - 1 - j; i++)
    {
        array[i, n - 1 - j] = x;
        x++;
    }
    for (int i = m - 1 - j; i > 0 + j; i--)
    {
        array[m - 1 - j, i] = x;
        x++;
    }
    for (int i = m - 1 - j; i > 0 + j; i--)
    {
        array[i, 0 + j] = x;
        x++;
    }
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
PrintArray(array);
