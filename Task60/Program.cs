// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    int temp = new Random().Next(1, 10);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp;
                temp = temp + new Random().Next(1, 10);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"{array[i, j, l]} ({i}, {j}, {l})" + "\t");
            }
            Console.WriteLine();
        }

    }

}

Console.Write("Введите первое значение массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение массива: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье значение массива: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] array = FillArray(a, b, c);
PrintArray(array);
