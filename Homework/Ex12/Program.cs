// Задача 12:** Удалить вторую цифру трёхзначного числа.
using static System.Console;
WriteLine("Напишите трехзначное число и я удалю второе - ");
string a = ReadLine();
a = (a[0].ToString()) + (a[2].ToString());
WriteLine(a);
