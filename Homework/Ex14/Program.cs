// Задача 14:** Найти третью цифру числа или сообщить, что её нет.
using static System.Console;
WriteLine("Напишите число и я найду 3ю цифру");
int number = int.Parse(ReadLine());
int [] size = {1, 2, 3};
if (number < size.Length)
{
    WriteLine("В числе нету 3 цифры");
}
else
{
    string third = (int.Parse(number[2].ToString()));
    WriteLine("3я цифра - " + third);
}
