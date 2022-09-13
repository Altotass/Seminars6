// Задача HARD SORT. Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

void Sortmassiv()
{
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

Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[m, n];
Console.WriteLine("=========================================================");
Fillmassiv(massiv);
Printmassiv(massiv);
Console.WriteLine("=========================================================");

int temp = 0;
for (int k = 0; k < m; k++)
    {   for (int r = 0; r < n; r++)
        {   for (int i = 0; i < m; i++)
            {   for (int j = 0; j < n; j++)
                {   if (massiv[i,j] > massiv[k,r])
                    {   temp = massiv[i,j];
                        massiv[i,j] = massiv[k,r];
                        massiv[k,r] = temp;
                    }
                }
            }
        }
    }
for (int i = 0; i < m; i++)
    {   for (int j = 0; j < n; j++)
        Console.Write(massiv[i,j] + "\t");
        {    Console.WriteLine("");
        }
    }
}   
Sortmassiv();