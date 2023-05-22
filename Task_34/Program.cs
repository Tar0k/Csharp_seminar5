﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//
//     [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
var array = new int[4].Select(val =>new Random().Next(100, 999)).ToArray();
Console.Write("[" + string.Join(",", array) + "]");
var positiveNumbers = array.Count(val => val % 2 == 0);
Console.WriteLine($" -> {positiveNumbers}");