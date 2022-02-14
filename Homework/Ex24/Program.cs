// Найти кубы чисел от 1 до N
using static System.Console;
int number = int.Parse(ReadLine());
int index = 0;
double score = 0;
while (index<number) {
    index++;
    score = index*index*index;
    WriteLine($"Куб числа {index} равен {score}");
}
