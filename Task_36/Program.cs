// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//     [3, 7, 23, 12] -> 19
//     [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
var array = new int[6].Select(val => new Random().Next(0, 10)).ToArray();
Console.Write("[" + string.Join(",", array) + "]");
var oddPositionValues = array.Where((value, index) => index % 2 == 1).ToArray();
//Console.Write("[" + string.Join(",", oddPositionValues) + "]");
Console.WriteLine($" -> {oddPositionValues.Sum()}");
