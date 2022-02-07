// Задача 8:** Показать чётные числа от 1 до N.
int N = 14;
int[] array = new int[N+1];
int index = 0;
Console.WriteLine("Четные числа от 1 до " + N);
while (index < array.Length)
{

    array[index] = index;

    if (array[index] % 2 == 1)
    {

    }
    else
    {
        Console.WriteLine(array[index]);
    }
    index++;
}
