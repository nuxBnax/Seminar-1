﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//  456 -> 6
//  782 -> 2
//  918 -> 8

Console.WriteLine("Enter Triple number: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine(A % 10);
if (A > 99 && A<1000)
{
    Console.WriteLine(A % 10);
}
else
{
    Console.WriteLine("Error!");
}