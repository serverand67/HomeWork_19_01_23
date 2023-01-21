﻿/*Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int getUserMsg(string msg)
{
    Console.WriteLine(msg);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}

double b1 = getUserMsg(" Введите значение b1 ");
double k1 = getUserMsg(" Введите значение k1 ");
double b2 = getUserMsg(" Введите значение b2 ");
double k2 = getUserMsg(" Введите значение k2 ");
double x = 0;
double y = 0;
x = (-b2 + b1)/(-k1 + k2);
y = k2 * x + b2;
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");