// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Average ()
{
void FillArray(double[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
    {   for (int j = 0; j < array.GetLength(1); j++)
        {    array[i, j] = Convert.ToDouble(new Random().Next(1, 10));
        }
    }
}
void PrintArray(double[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
    {   for (int j = 0; j < array.GetLength(1); j++)
        {   Console.Write(array[i, j]  + "\t");
        }
            Console.WriteLine("");
    }
}

Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] massiv = new double[m, n];
Console.WriteLine("=========================================================");
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("=========================================================");
    for (int j = 0; j < massiv.GetLength(1); j++)
    {   double sum = 0;
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
        sum = massiv[i,j] + sum;
        }
        sum = Math.Round(sum / massiv.GetLength(0), 1);
        Console.Write(sum + "\t");
    }
}
Average();