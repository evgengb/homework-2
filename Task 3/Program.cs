﻿// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int A = new Random().Next(100, 1000);

if (A >=100 && A < 1000)
{
    int rez = A/100;
    int rez2 = A%10;
    System.Console.WriteLine($"{A} = {rez}{rez2}");
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}