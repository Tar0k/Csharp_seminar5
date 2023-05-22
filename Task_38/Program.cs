// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//     Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

Console.WriteLine("Задача 38: Задайте массив вещественных чисел." +
                  " Найдите разницу между максимальным и минимальным элементов массива. Диапазон [-10, 10]." +
                  " Обратите внимание на вещественных чисел");
var array = new double[5].Select(val => GenerateScaledRandom()).ToArray();
Console.WriteLine("[" + string.Join("  ", array) + "]");
var difference = array.Max() - array.Min();
Console.WriteLine($"Разница: {difference}");



double GenerateScaledRandom() => Math.Round(20 * new Random().NextDouble() - 10, 3);