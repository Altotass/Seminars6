// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void Vozvrat()
{
void FillArray(int[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
    {   for (int j = 0; j < array.GetLength(1); j++)
        {    array[i, j] = Convert.ToInt32(new Random().Next(10, 99));
        }
    }
}
void PrintArray(int[,] array)
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
int[,] massiv = new int[m, n];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("Введите позицию элемента в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > m - 1 | y > n - 1) 
{    Console.WriteLine("Такой позиции в массиве нет");
}
else
{    Console.WriteLine("Значение элемента массива = {0}", massiv[x, y]);
}
}
Vozvrat();