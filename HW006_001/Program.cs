﻿// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите нужное колличество чисел: ");
// int n = int.Parse(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < n; i++)
//     {
//     Console.Write($"Введите число {i + 1}: ");
//     int x = int.Parse(Console.ReadLine());
//     if (x > 0)
//     count++;
//     }
// Console.WriteLine($"Положительных чисел: {count}");

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
// а подсчет количества чисел производится после того, 
// как пользователь не ввел информацию и нажал Enter.

Console.Write("Введите числа (через пробел) и нажмите Enter: ");
int[] mass = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
    for (int i = 0; i < mass.Length; i++)
        {
        if (mass[i] > 0)
        count++;
        }
Console.WriteLine($"Положительных чисел: {count}");
