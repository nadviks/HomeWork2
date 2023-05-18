// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

//bool palindrom = palindrom(number);
// string finAnswer = palindrom == true ? $"Число {number} -> является палиндромом!" : $"Число {number} -> не является палиндромом!";
// Console.WriteLine(finAnswer); 
if (palindrom(interval(number)))
{
    Console.WriteLine($"число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
bool palindrom(int num)
{
    int firstNum = num / 10000;
    int secondNum = num / 1000 % 10;
    int fourthNUM = num % 100 / 10;
    int fifthNum = num % 10;
    return firstNum == fifthNum && secondNum == fourthNUM ? true : false;
}

//int interval=interval(number);

int interval(int num)
{
    while (((num<-99999) || ((num>-10000) && (num<10000)) || (num>99999)))
    {
        Console.WriteLine("Данное число не является пятизначным! Введите другое число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}


// int ReversNumb(int n)
// {
//     int reverse = 0;
//     if (n <= -10 || n >= 10)
//     {
//         while (n != 0)
//         {
//             int remain = n % 10;
//             reverse = reverse * 10 + remain;
//             n = n / 10;
//         }
//         return (reverse);
//     }
//     return 0;
// }

