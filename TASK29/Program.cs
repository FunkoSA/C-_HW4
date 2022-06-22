/*
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
* 6, 1, 33 -> [6, 1, 33]
*/

using System;
using  static System.Console;

Clear();
WriteLine("Данная программа осуществляет заполнение одномерного массива и выводит его на экран");
Write("Введите из какого количества элементов необходимо сформировать массив: ");
int A = int.Parse(ReadLine());
WriteLine("Массив будет сформирован с помощью генератора случайных чисел.");
Write("Введите минимальное возможное значение элемента для заполнения массива: ");
int minValue = int.Parse(ReadLine());
Write("Введите максимаьное возможное значение элемента для заполнения массива: ");
int maxValue = int.Parse(ReadLine());

//Заполним массив используя описанный ниже метод
int[] arrayN = GetRandomArray(A,minValue,maxValue);

WriteLine($"Вывод на экран массива из {A} элемонтов с использованием метода PrintArray:");
PrintArray(arrayN);

//String.Join работает только с одномерными массивами
WriteLine($"Вывод на экран массива из {A} элемонтов с использованием String.Join");
WriteLine($"[{String.Join(",",arrayN)}]");


// Описание метода вывода на экран массива
void PrintArray (int[] array)
{
    Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]},"); 
    }
    WriteLine($"{array[array.Length - 1]}]");
}

//Описание метода заполнения массива из N элементов генератором случайных чисел
int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }

    return result;
}