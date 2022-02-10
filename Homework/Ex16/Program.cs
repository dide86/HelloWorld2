// Задача 16:** Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = new Random().Next(1, 8);
Console.WriteLine(a);
if (a == 6) { Console.WriteLine(a + " - Суббота"); }

else if (a == 7) { Console.WriteLine(a + " - Воскресенье"); }

else { Console.WriteLine(a + " - рабочий день"); };
