// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
    Console.WriteLine(secondNumber(number));
}

int secondNumber(int n)
{ int result = ((n / 10) % 10);
return result;
}