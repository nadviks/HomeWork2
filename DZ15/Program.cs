// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите день недели:");
int dayNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(weekDay(dayNumber));

string weekDay(int number)
{
    if (number > 0 && number < 8)
    {
        if (number == 6 || number == 7)
        {
            Console.Write("Да, выходной ");
        }
        else
        {
            Console.Write("Нет, не выходной ");
        }
    }
    else
        {
            Console.Write("ВВедите число от 1 до 7, чтобы определить ");
        }
        return "день.";
}
