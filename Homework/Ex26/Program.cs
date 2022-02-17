// Задача 26: Возведите число А в натуральную степень B, используя цикл.
using static System.Console;
int number = 5;
int step = 1;
int index = 1;
int result = number;
while ( index < step) {
result = result * number;
index++;
}
WriteLine(result);