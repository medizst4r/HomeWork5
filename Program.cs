﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


/*
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("В данном массиве: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
/*
int [] CreateRandomArray ()
{
    int size = 11;
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(-10, 20);
    }
    return array;
}
int SumNumOddElements (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2)
        {
        sum = sum + array[i];
        Console.Write ($"{array[i]} ");
        }
    return sum;
}
int [] myArray = CreateRandomArray();
ShowArray(myArray);
Console.WriteLine("- Sum of numbers of the odd's elements = " + (SumNumOddElements (myArray)));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
/*
double [] CreateRandomArray (int size, int minValue, int maxValue)
{
    double [] array = new double [size];
        for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
                   
    }
    return array;
}

void ShowArrayD ( double [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write($"{Math.Round (array [i],2)}  ");
    Console.WriteLine();    
}

double DifferenceMaxMin (double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
       {
        if ( array[i] > max )
            max = array [i];
        if ( array[i] < min)
            min = array [i];
       }
    double dif = max - min;
    return dif;
}

Console.WriteLine("Input a number of elements");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

double [] myArray = CreateRandomArray(n, min, max);

ShowArrayD(myArray);

Console.WriteLine(" Difference between Max and Min = " + Math.Round ((DifferenceMaxMin (myArray)),2) );
*/