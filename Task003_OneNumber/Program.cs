﻿// Задача №5. Напишите программу, которая на 
// вход принимает одно число (N), а на выходе 
// показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Enter your number, please");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = -N;
// while (i <= N)
// {
//     Console.Write (i + " ");
//     i++;
// }

Console.WriteLine("Enter your number, please");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}