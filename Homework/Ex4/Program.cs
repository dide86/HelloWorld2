// Задача 4:** Найти максимальное из трёх чисел.
int a = 1;
int b = 4;
int c = 9;

int max = a;

if(b>max) max = b;
if(c>max) max = c;
Console.WriteLine("Максимальное число - " + max);