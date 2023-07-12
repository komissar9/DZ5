// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
int size = 10;
int [] numbers = new int [size];
int count = 0;
for (int i = 0; i < size; i++)
{
    numbers [i] = new Random().Next(100,1000);
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: [ {string.Join("; ", numbers)} ]");
Console.WriteLine ($"В массиве количество чётных чисел: {count}");

// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
int size = 10;
int [] numbers = new int [size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    numbers [i] = new Random().Next(100,1000);
    if (i % 2 == 1)
    {
        sum = sum + numbers [i];
    }
}
Console.WriteLine($"Массив: [ {string.Join("; ", numbers)} ]");
Console.WriteLine ($"Сумма элементов на нечетных позициях: {sum}");

// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
double[] GetArray(int size, int min, int max)
{
    double[] result = new double[size];
    Random number = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = number.Next(min,max+1) + Math.Round(number.NextDouble(), 2);
    }
    return result;
}
double[] array = GetArray(10, 100, 1000);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
double Min = array[0];
double Max = array[0];
double diff = 0;
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < Min)
    {
        Min = array[i];
    }
    if (array[i] > Max)
    {
        Max = array[i];
    }
    diff = Max - Min;
}
Console.WriteLine($"Максимальное число: {Max}");
Console.WriteLine($"Минимальное число: {Min}");
Console.WriteLine($"Разница: {diff}");
