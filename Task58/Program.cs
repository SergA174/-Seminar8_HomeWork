// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите количество строк для первой матрицы: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы(строк для второй): ");
int o = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для второй матрицы: ");
int v = Convert.ToInt32(Console.ReadLine());
if(o == z && o == v)
{
    int[,] Martrix1 = new int[z, o];
    CreateArray(Martrix1);
    Console.WriteLine($"Первая матрица:");
    PrintArray(Martrix1);

    int[,] Martrix2 = new int[o, v];
    CreateArray(Martrix2);
    Console.WriteLine($"Вторая матрица:");
    PrintArray(Martrix2);


    int[,] countMatrix = new int[z, v];

    CompositMatrix(Martrix1, Martrix2, countMatrix);
    Console.WriteLine($"Произведение первой и второй матриц:");
    PrintArray(countMatrix);

    void CompositMatrix(int[,] Martrix1, int[,] Martrix2, int[,] countMatrix)
    {
        for (int i = 0; i < countMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < countMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int x = 0; x < Martrix1.GetLength(1); x++)
                {
                    sum = sum + Martrix2[i, x] * Martrix1[x, j];
                }
                countMatrix[i, j] = sum;
            }
        }
    }
    void CreateArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 5);
            }
        }
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
else Console.WriteLine("Введены некорректные данные");
