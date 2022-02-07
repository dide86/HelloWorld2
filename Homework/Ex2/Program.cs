// Задача 2:** Даны два числа. Показать большее и меньшее число
int a = 7;
int b = 9;
int max = a;
int min = b;
if(b>max) {
    max = b;
    min = a;
    }
Console.WriteLine("Максимальное число - " + max);

Console.WriteLine("Минимальное число - " + min);
