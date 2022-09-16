// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Proizv2massiva()
{   Console.WriteLine("Введите размер матриц: ");
    int m = Convert.ToInt32(Console.ReadLine());
void Fillmassiv(int[,] massiv)
{   for (int i = 0; i < massiv.GetLength(0); i++)
    {   for (int j = 0; j < massiv.GetLength(1); j++)
        {   massiv[i, j] = new Random().Next(1, 10); 
        }
    }
}
void PrintArray(int[,] massiv)
{   for (int i = 0; i < massiv.GetLength(0); i++)
    {   for (int j = 0; j < massiv.GetLength(1); j++)
        {   Console.Write(massiv[i, j]  + "\t");
        }
            Console.WriteLine("");
    }
}
int[,] massivA = new int[m, m];
int[,] massivB = new int[m, m];
Fillmassiv(massivA);
Fillmassiv(massivB);
int[,] massivC = new int[m, m];
for (int i = 0; i < m; i++)
{   for (int j = 0; j < m; j++)
    {   for (int k = 0; k < m; k++)
        {    massivC[i, j] = massivC[i, j] + (massivA[i, k] * massivB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - X");
PrintArray(massivA);
Console.WriteLine("Матрица - Y");
PrintArray(massivB);
Console.WriteLine("Произведение матриц - X*Y");
PrintArray(massivC);
}
Proizv2massiva();