// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
// int size = 10;
// int [] numbers = new int [size];
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     numbers [i] = new Random().Next(100,1000);
//     if (numbers[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", numbers)} ]");
// Console.WriteLine ($"В массиве количество чётных чисел: {count}");

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