// Задать номер четверти, показать диапазоны для возможных координат
using static System.Console;
int number = int.Parse(ReadLine());
if (number == 1)
{
    WriteLine("Диапазон координат для 1ой четверти x > 0 , y > 0 ");
}
else if (number == 2)
{
    WriteLine("Диапазон координат для 2ой четверти x < 0 , y > 0 ");
}
else if (number == 3)
{
    WriteLine("Диапазон координат для 3ой четверти x < 0 , y < 0");
}else if (number == 4){
    WriteLine("Диапазон координат для 4ой четверти x > 0 , y < 0 ");
}else {
    WriteLine("Неверно указана четверть");
}