/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

using System;
using  static System.Console;

Clear();
WriteLine("Данная программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
Write("Введине число, которое будем воззводить в степень (А): ");
int A = int.Parse(ReadLine());
Write("Введине в какуюстепень (В) будем воззводить число А: ");
int B = int.Parse(ReadLine());

WriteLine ($"Результат воззведения числа {A} в {B}-ю степень следующий: {Exponentiation(A, B)}");

double Exponentiation(int bases,  int index)
{
    int exp = 1;
    for (int i = 0; i < index; i++)
    {
        exp *=  bases;
    }

    return exp;
}