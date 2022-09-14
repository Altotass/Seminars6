// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:       В итоге получается вот такой массив:
// 1 4 7 2                            7 4 2 1
// 5 9 2 3                            9 5 3 2
// 8 4 2 4                            8 4 4 2

Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[m, n];

void Fillmassiv(int[,] massiv)
{   for (int i = 0; i < massiv.GetLength(0); i++)
    {   for (int j = 0; j < massiv.GetLength(1); j++)
        {    massiv[i, j] = (new Random().Next(1, 10));
        }
    }
}
void Printmassiv(int[,] massiv)
{   for (int i = 0; i < massiv.GetLength(0); i++)
    {   for (int j = 0; j < massiv.GetLength(1); j++)
        {   Console.Write(massiv[i, j]  + "\t");
            }
            Console.WriteLine("");
    }
}
void Sortmassiv(int[,] massiv)
{
for (int k = 0; k < m; k++)
    {   for (int r = 0; r < n; r++)
        {   for (int i = 0; i < m; i++)
            {   for (int j = 0; j < n ; j++)
                {   if (massiv[i,j] < massiv[i,r])
                    {   int temp = massiv[i,j];
                        massiv[i,j] = massiv[i,r];
                        massiv[i,r] = temp;
                }
            }
        }
    }
}
}
Console.WriteLine("=========================================================");
Fillmassiv(massiv);
Printmassiv(massiv);
Console.WriteLine("=========================================================");
Sortmassiv(massiv);
Printmassiv(massiv);