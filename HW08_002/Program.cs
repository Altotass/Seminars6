// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSum()
{
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
{   int index = 0; 
    int min = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {   int sum = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
            {   sum = massiv[i,j] + sum;   
            }
                if (i == 0)
                {   min = sum;
                }
                    else if (sum < min)
                    {   min = sum;
                        index = i+1;
                    }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - {index}. ");
}
Console.WriteLine("=========================================================");
Fillmassiv(massiv);
Printmassiv(massiv);
Console.WriteLine("=========================================================");
Sortmassiv(massiv);
}
MinSum ();