// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void QQQ()
{
Console.WriteLine ("Напишите начальное число M");
    Console.Write ("M = ");
    int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Напишите конечное число N");
    Console.Write ("N = ");
    int N = Convert.ToInt32(Console.ReadLine());

 int SumNumbers(int M, int N)
            {
                if (N==M) return M; 
                return N + SumNumbers(M,N-1);
            }
Console.WriteLine("Сумма чисел " + SumNumbers(M,N));
}
QQQ();