﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры!!!");
}
else
{
    Console.WriteLine(thirdNumber(number));
}

int thirdNumber(int num);
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}
