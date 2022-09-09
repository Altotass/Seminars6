    // задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - 
// площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, 
// равнобедренным, равносторонним.

    Console.Write("Введите первую сторону треугольника: ");
    double a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: ");
    double b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: ");
    double c = Convert.ToInt32(Console.ReadLine());
        double P = 0;
        double S = 0;
        double G = (a + b + c) / 2;
        double A3 = 0;
        double B1 = 0;
        double C1 = 0;
        if (a < b + c && b < a + c && c < a + b) 
        {   Console.WriteLine($"Perimetr = {P = a + b + c}");
            Console.WriteLine($"Ploshad = {S = Math.Sqrt(G * (G - a) * (G - b) * (G - c))}");
        }
        else 
        { Console.WriteLine("Треугольник не возможен.");            
        }
        if (A3 == 90 || B1 == 90 || C1 == 90)
{    Console.WriteLine("Треугольник прямоугольный.");  
}
if (a == b && b == c)
{    Console.WriteLine("Треугольник равносторонний.");    
}
if (a == b || b == c || a == c)
{    Console.WriteLine("Треугольник равнобедренный.");   
}
else
{    Console.WriteLine("Треугольник обычный :) ");
}
UGOL();

    void UGOL()
    {   double A1 = (b * b + c * c - a * a) / (2 * b * c);
        double A2 = Math.Acos(A1);
        double A3 = Math.Acos(A1) * 180d / Math.PI;
        double A4 = b * (double)Math.Sin(A2) / a;
        double B1 = Math.Asin(A4) * 180d / Math.PI;
        double B2 = A2 * 180d / Math.PI;
        double C1 = 180d - A3 - B1;    
        Console.WriteLine($"Углы (а =) {A3}, (в =) {B1}, (с =) {C1}");
    }    
    
