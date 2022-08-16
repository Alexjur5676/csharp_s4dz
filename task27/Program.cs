// Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
int i;
int sum = 0;
while (number > 0)
{
    i = number % 10;
    number = number / 10;
    sum = sum + i;
}
Console.WriteLine(sum);


