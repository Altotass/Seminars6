// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void XXX()
{
Console.WriteLine ("Напишите начальное число M");
    Console.Write ("M = ");
    int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Напишите конечное число N");
    Console.Write ("N = ");
    int N = Convert.ToInt32(Console.ReadLine());

 string AllNumbers(int N)
            {
                if (N==M) return Convert.ToString(M);
                return AllNumbers(N-1) + ", " + Convert.ToString(N);
            }
Console.WriteLine("ряд чисел " + AllNumbers(N));
}
XXX();
