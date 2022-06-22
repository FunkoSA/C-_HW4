/*
    Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

* 452 -> 11
* 82 -> 10
* 9012 -> 12
*/

using System;
using  static System.Console;

Clear();
WriteLine("Данная программа выводит сумму цифр, введенного с клавиатуры числа");
Write("Введите число, сумму цифр которого необходимо вычислить: ");
int A = int.Parse(ReadLine());

WriteLine ($"Сумма цифр числа {A} равна: {SumNumber(A)}");

int SumNumber (int number)
{
    int result = 0;
    for (int temp = A; temp !=0; temp/=10)
    {
        result = result + temp % 10; 
    }
    return result;
}